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
        public Form1()
        {
            //Mostrar formulario como ventana MDI
            InitializeComponent();
            Form2 conexion = new Form2();
            conexion.MdiParent = this;
            conexion.StartPosition = FormStartPosition.CenterScreen;
            conexion.Show();
            
        }

    }
}
