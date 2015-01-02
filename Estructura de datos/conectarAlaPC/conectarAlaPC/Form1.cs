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

namespace conectarAlaPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort sp;
        private void btnConectar_Click(object sender, EventArgs e)
        {
            sp = new SerialPort("COM15", 9600, Parity.None, 8, StopBits.One);
            sp.Open();
            timer1.Enabled = true;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            sp.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x;
            char c;
            for (int i = 0; i < sp.BytesToRead; i++)
            {
                x = sp.ReadByte();
                if (x == 32 || (x <= 122 && x >= 48))
                {
                    c = (char)x;
                    txtMostrar.Text += c;
                }
                else if (x == 10)
                {
                    sp.ReadByte();
                    txtMostrar.Clear();
                    txtMostrar.Text += Environment.NewLine;
                }
            }
        }
    }
}
