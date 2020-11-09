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
    public partial class Form2 : Form
    {
        private string opcion;
        private string baud;
        
        public Form2()
        {
            InitializeComponent();
            BtnConectar.Enabled = false;
            BtnSiguiente.Enabled = false;
            CmbPuertos.SelectedIndex = 0;
            CmbBaud.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opcion = string.Empty;
            opcion = CmbPuertos.Text.ToString();
            baud = string.Empty;
            baud = CmbBaud.Text.ToString();
            //Valida que el usuario seleccione un puerto USB y un BaudRate
            if (opcion == "Seleccionar Puerto" || baud== "Seleccione una opción")
            {
                MessageBox.Show("Por favor seleccione puerto USB y Baud Rate");
            }
            else
            {
                //Establecer conexión
                if (conector.SetPortName(CmbPuertos.Text, CmbBaud.Text))
                {
                    MessageBox.Show("No se puede establecer la conexión, favor validar los puertos COM");

                }
                else {
                    MessageBox.Show("Conexión establecida");
                    BtnConectar.Enabled = false;
                    BtnSiguiente.Enabled = true;
                    LblInfo.Text = "Conexión establecida";
                }
            }
        }
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            // ocultar formulario conexión y mostrar formulario servicio
            Form3 servicio = new Form3();
            servicio.MdiParent = this.ParentForm;
            servicio.Show();
            this.Hide();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Busqueda de puertos USB conectados 
            CmbPuertos.Items.Clear();
            foreach (string puertosDisponibles in System.IO.Ports.SerialPort.GetPortNames())
            {
                CmbPuertos.Items.Add(puertosDisponibles);
                if (CmbPuertos.Items.Count > 0)
                {
                    BtnConectar.Enabled = true;
                }
            }
        }
    }
}

