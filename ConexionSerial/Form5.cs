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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // ocultar formulario parametros MUB y mostrar formulario servicio
            Form3 servicio = new Form3();
            servicio.MdiParent = this.ParentForm;
            servicio.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {            
            // ocultar formulario parametros MUB y mostrar formulario configuración
            Form6 configuracion = new Form6();
            configuracion.MdiParent = this.ParentForm;
            configuracion.Show();
            this.Hide();

        }
    }
}
