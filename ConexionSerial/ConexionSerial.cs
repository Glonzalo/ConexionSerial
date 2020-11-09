using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace ConexionSerial
{
   public  class ConexionSerial
    {
        public SerialPort puertoSerial;
        string puertoCom;

        public void Main() {
        }

        public static SerialPort(string com) {
            puertoSerial = new SerialPort();
            puertoSerial.PortName = name;
            puertoSerial.BaudRate = 9600;
            puertoSerial.Parity = Parity.None;
            puertoSerial.DataBits = 8;
            puertoSerial.Open();
        }


    }
}
