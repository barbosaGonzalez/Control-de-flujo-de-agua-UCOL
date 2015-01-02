using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_integrador
{
    public partial class frmFlujo : Form
    {
        public frmFlujo()
        {
            InitializeComponent();
        }

        Sensor operacion = new Sensor(); //Se establece una variable para la clase operacion

        private void btnSalir_Click(object sender, EventArgs e) //Boton salir
        {
            try //Si todo esta correcto
            {
                timer2.Enabled = false; //Se desactiva el timer 2
                operacion.CerrarPuerto(); //Se cierra el puerto COM
                timer1.Enabled = false; //Se desactiva el timer 1
            }
            catch (Exception ex) //Si hay algun problema
            {
                timer1.Enabled = false; //Se desactiva el timer
                timer2.Enabled = false; //Se desactiva el timer
                Close(); //Se cierra la aplicacion
                MessageBox.Show(ex.Message.ToString()); //Muestra un mensaje con el error
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try //Si todo es correcto
            {
                operacion.AbrirPuerto(); //Se abre el puerto COM
                timer2.Enabled = true; //Se activa el timer 2
                timer1.Enabled = true; //Se activa el timer 1
            }
            catch (Exception ex) //Si hay un error
            {
                timer1.Enabled = false; //Se desactiva el timer 1
                timer2.Enabled = false; //Se desactiva el timer 2
                MessageBox.Show(ex.Message.ToString());  //Muestra un mensaje con el error
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try //Si todo esta bien
            {
                operacion.Leer(); //Lee los datos del sensor
                txtMostrarSensor.Text = operacion.datosSensor; //Imprime en el textbox la cadena con los datos arrojados
            }
            catch (Exception ex) //Si hay algun error
            {
                MessageBox.Show(ex.Message.ToString()); //Muestra un mensaje con el error
                timer2.Enabled = false; //Se desactiva timer 2
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try //Si todo esta bien
            {
                operacion.Guardar(); //Se manda a llamar la operacion para guardar en la base de datos
                txtMostrarGuardar.Text += operacion.cadenaGuardar; //Se muestra lo que se guardara
            }
            catch (Exception ex) //Si hay algun error
            {
                MessageBox.Show(ex.Message.ToString());  //Muestra un mensaje con el error
                timer1.Enabled = false; //Se desactiva el timer 1
            }
        }
    }
}
