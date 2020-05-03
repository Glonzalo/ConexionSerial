using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;


namespace ConexionSerial
{
    public partial class Form1 : Form
    {
        private delegate void DelegadoAcceso(string accion);
        private String strBufferIn;
        private String strBufferOut;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnConectar.Enabled = false;
            BtnEnviarDatos.Enabled = false; 
        }

        private void BtnBuscarPuertos_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            
            CboPuertos.Items.Clear();

            foreach (string  puerto_simple in PuertosDisponibles)
            {
                CboPuertos.Items.Add(puerto_simple);
            }

            if (CboPuertos.Items.Count > 0)
            {
                CboPuertos.SelectedIndex = 0;
                BtnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existen dispositivos conectados");
                CboPuertos.Items.Clear();
                strBufferIn = " ";
                strBufferOut = " ";
                BtnConectar.Enabled = false;
                BtnEnviarDatos.Enabled = false;

            }

        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnConectar.Text=="Conectar")
                {
                    SpPuertos.BaudRate = 9600;
                    SpPuertos.DataBits = 8;
                    SpPuertos.Parity = Parity.None;
                    SpPuertos.StopBits = StopBits.One;
                    SpPuertos.PortName = CboPuertos.Text;
                    try
                    {
                        SpPuertos.Open();
                        BtnConectar.Text = "Desconectar";
                        BtnEnviarDatos.Enabled = true;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString());
                    }
                }
                else if (BtnConectar.Text == "Desconectar")
                {
                    SpPuertos.Close();
                    BtnConectar.Text = "Conectar";
                    BtnEnviarDatos.Enabled = false;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }

        }

        private void BtnEnviarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                SpPuertos.Write("show conf");
                SpPuertos.Write(new byte[] {13, 0}, 0, 1);
            }
            catch (Exception exc) 
            { 
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            strBufferIn = SpPuertos.ReadExisting();
            this.Invoke(new EventHandler(MostrarDatos));
        }

        private void MostrarDatos(object sender, EventArgs e)
        {
            TxtDatosRecibidos.Text += strBufferIn;
            TxtDatosRecibidos.SelectionStart = TxtDatosRecibidos.Text.Length;
            TxtDatosRecibidos.ScrollToCaret();

            if (TxtDatosRecibidos.Text.Contains("--More--"))  
            {
                if (TxtDatosRecibidos.Text.Contains("line vty 0 4") == false)
                {
                    SpPuertos.Write(new byte[] { 32, 0 }, 0, 1);
                    TxtDatosaEnviar.Text = "prueba exitosa";
                }
            }
        }

        private void TxtDatosaEnviar_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                try
                {
                    SpPuertos.DiscardOutBuffer();
                    strBufferOut = TxtDatosaEnviar.Text;
                    SpPuertos.Write(strBufferOut);
                    SpPuertos.Write(new byte[] { 13, 10 }, 0, 1);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message.ToString());
                }
            }
        }
    }
}
