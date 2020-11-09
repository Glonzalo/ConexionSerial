using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionSerial
{
    public partial class Form3 : Form
    {
        private string servicio;
        private string modelo;
        public Form3()
        {
            InitializeComponent();
            LblAlertaServicio.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void LblAlertaServicio_Click(object sender, EventArgs e)
        {

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            servicio = string.Empty;
            modelo = string.Empty;
            servicio = CmbServicio.Text.ToString();
            modelo = CmbModelo.Text.ToString();
            switch (servicio)
            {
                //Opcion 1, servicio no seleccionado
                case "":
                MessageBox.Show("Por favor seleccione servicio a configurar");
                    break;
                //Opcion 2, servicio IPF
                case "IPF":
                    if (modelo == "")
                    {
                        MessageBox.Show("Por favor seleccione modelo del router a configurar");
                    }
                    else {
                        // ocultar formulario conexión y mostrar formulario parametros IPF
                        Form4 ipf = new Form4();
                        ipf.MdiParent = this.ParentForm;
                        ipf.Show();
                        this.Hide();
                    }
                    break;
                //Opcion 3, servicio MUB
                case "MUB":
                    if (modelo == "")
                    {
                        MessageBox.Show("Por favor seleccione modelo del router a configurar");
                    }
                    else
                    {
                        // ocultar formulario conexión y mostrar formulario parametros MUB
                        Form5 ipf = new Form5();
                        ipf.MdiParent = this.ParentForm;
                        ipf.Show();
                        this.Hide();
                    }
                    break;
            }
        }
    }
}
