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

    public partial class frmPrincipal : Form
    
    {        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "..:: Programa Funcionando ::..";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte frm = new frmReporte();   //Llama al segundo formulario
            this.Hide(); 
            frm.ShowDialog();   //Ejecuta el Segundo Formulario sin permitir regresarse al primer formulario
            this.Show();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "..:: Conectando puerto ::..";
            frmFlujo frm = new frmFlujo();   //Llama al segundo formulario
            this.Hide();
            frm.ShowDialog();   //Ejecuta el Segundo Formulario sin permitir regresarse al primer formulario
            this.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "..:: Leyendo datos de los sensores ::..";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "..:: Guardando Datos ::..";
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "..:: Saliendo ::..";
            
            DialogResult dialogResult = MessageBox.Show("¿Deseas salir?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                toolStripStatusLabel1.Text = "..:: Menu Principal ::..";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }
    }
}
