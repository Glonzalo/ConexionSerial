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
    public partial class Form6 : Form
    {
        public SerialPort puertoSerial;
        public Form6()
        {
            InitializeComponent();
        }

        public Form6(SerialPort puertocom)
        {
            puertoSerial = puertocom;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = conector.leerDatos();
        }
    }
}
