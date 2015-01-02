using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grafos_Colima
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Graph grafo = new Graph();

        private void button1_Click(object sender, EventArgs e)
        {
            tbxOutRutes.Clear();

            grafo.getRute();
            tbxOutRutes.Text= grafo.bestWay(combobxInitialPoint.SelectedIndex, combobxFinalPoint.SelectedIndex);
        }
    }
}
