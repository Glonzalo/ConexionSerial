using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace ConexionSerial
{
    public class conector
    {
        public static SerialPort puertoSerial;

        public static Boolean SetPortName(string name, string Baud){
            // Parametros de conexión
            puertoSerial = new SerialPort();
            puertoSerial.PortName = name;
            puertoSerial.BaudRate = Int32.Parse(Baud);
            puertoSerial.DataBits = 8;
            puertoSerial.Parity = Parity.None;
            try
            {
                // Si la conexión esta inactiva se conecta y devuelve un false
                puertoSerial.Open();
                return false;
            }
            catch (Exception)
            {
                // Si la conexión esta activa devuelve true
                return true;
            }
        }

        public static string leerDatos()
        {
            puertoSerial.Write("\r\n");
            puertoSerial.Write("\r\n");
            string lectura = puertoSerial.ReadLine();
            return lectura;
        }







    }
}
