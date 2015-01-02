using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Proyecto_integrador
{
    class Sensor
    {
        SerialPort puerto;
        EnviarEmail correo = new EnviarEmail();
        BaseDatos basesql = new BaseDatos();
        private double sensor1 = 0, sensor2 = 0, sensor3 = 0, totalS1 = 0, totalS2 = 0, totalS3 = 0;
        private bool limite1 = true, limite2 = true, limite3 = true;
        private string[] recibido = new string[3];
        private string _datosSensor, _cadenaGuardar;

        public string cadenaGuardar
        {
            get { return _cadenaGuardar; }
            set { _cadenaGuardar = value; }
        }

        public string datosSensor
        {
            get { return _datosSensor; }
            set { _datosSensor = value; }
        }
        private int x;
        private char c;

        public void Leer()
        {
            for (int i = 0; i < puerto.BytesToRead; i++)
            {
                x = puerto.ReadByte();
                if ((x <= 57 && x >= 32))
                {
                    c = (char)x;
                    datosSensor += c.ToString();
                }
                else if (x == 10)
                {
                    puerto.ReadByte();
                    recibido = datosSensor.Split(',');
                    if (recibido.Length == 3)
                    {
                        sensor1 += ((Convert.ToDouble(recibido[0])) * (0.1));
                        sensor2 += ((Convert.ToDouble(recibido[1])) * (0.1));
                        sensor3 += ((Convert.ToDouble(recibido[2])) * (0.1));
                    }
                    datosSensor = "";
                }
            }
        }

        public void Guardar()
        {
            sensor1 = Math.Round(sensor1, 3);
            sensor2 = Math.Round(sensor2, 3);
            sensor3 = Math.Round(sensor3, 3);
            totalS1 += sensor1;
            totalS2 += sensor2;
            totalS3 += sensor3;
            cadenaGuardar = "Sensor 1: " + sensor1.ToString() + " / " + "Sensor 2: " + sensor2.ToString() + " / " + "Sensor 3: " + sensor3.ToString() + " --> " + DateTime.Now.ToString() + Environment.NewLine +
                             "Total S1: " + totalS1.ToString() + " / " + "Total S2: " + totalS2.ToString() + " / " + "Sensor 3: " + totalS3.ToString() + Environment.NewLine +
                             "----------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
            if (totalS1 > 1000)
            {
                correo.Enviar("Sensor 1");
                totalS1 = 0;
                totalS2 = 0;
                totalS3 = 0;
                limite1 = false;
            }
            if (totalS2 > 1000)
            {
                correo.Enviar("Sensor 2");
                totalS1 = 0;
                totalS2 = 0;
                totalS3 = 0;
                limite2 = false;
            }
            if (totalS3 > 1000)
            {
                correo.Enviar("Sensor 3");
                totalS1 = 0;
                totalS2 = 0;
                totalS3 = 0;
                limite3 = false;
            }
            basesql.Write(sensor1, sensor2, sensor3, totalS1, totalS2, totalS3, limite1, limite2, limite3);
            sensor1 = 0;
            sensor2 = 0;
            sensor3 = 0;
        }

        public void AbrirPuerto()
        {
            puerto = new SerialPort("COM15", 9600, Parity.None, 8, StopBits.One);
            puerto.Open();
        }

        public void CerrarPuerto()
        {
            puerto.Close();
        }
    }
}

