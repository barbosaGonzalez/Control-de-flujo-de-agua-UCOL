using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_integrador
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private DataTable Cuadro_Estadistico = new DataTable();
        
        double[] VectorS1;
        double[] VectorS2;
        double[] VectorS3;
        double[] Resultado;
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection cn = new MySqlConnection();
        MySqlDataReader dr;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int Id = 0, inicializador1 = 0, inicializador2 = 0, inicializador3 = 0, media = 0;
            double MediaS1 = 0, MediaS2 = 0, MediaS3 = 0;
            txtMediaS1.Text = "";
            txtMediaS2.Text = "";
            txtMediaS3.Text = "";
            lsbMediaS1.Items.Clear();
            lsbMediaS2.Items.Clear();
            lsbMediaS3.Items.Clear();
            lsbVS3.Items.Clear();
            lsbVS2.Items.Clear();
            lsbVS1.Items.Clear();
            cn.ConnectionString = "Server=localhost;Database=sensores;User id=Edsel;Password=e.-94B:_41";
            cmd.Connection = cn;
            try
            {
                //Determinar numero de registros
                string q = "SELECT * FROM sensor1";
                cmd.CommandText = q;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    while (dr.Read())
                        Id++;
                dr.Close();
                cn.Close();
                VectorS1 = new double[Id]; //Inicializar vector
                VectorS2 = new double[Id]; //Inicializar vector
                VectorS3 = new double[Id]; //Inicializar vector
                Resultado = new double[Id]; //Inicializar vector
                media = Id / 2; //Determinar media

                //Sacar Media del sensor 1
                string y = "SELECT * FROM sensor1 Where Id = '" + media + "'";
                cmd.CommandText = y;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    while (dr.Read())
                        MediaS1 += double.Parse(dr[2].ToString());
                dr.Close();
                cn.Close();

                //Sacar Media del sensor 2
                string r = "SELECT * FROM sensor2 Where Id = '" + media + "'";
                cmd.CommandText = r;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    while (dr.Read())
                        MediaS2 += double.Parse(dr[2].ToString());
                dr.Close();
                cn.Close();

                //Sacar Media del sensor 3
                string s = "SELECT * FROM sensor3 Where Id = '" + media + "'";
                cmd.CommandText = s;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    while (dr.Read())
                        MediaS3 = double.Parse(dr[2].ToString());
                dr.Close();
                cn.Close();
                txtMediaS1.Text = MediaS1.ToString();
                txtMediaS2.Text = MediaS2.ToString();
                txtMediaS3.Text = MediaS3.ToString();

                //Restas del sensor1
                string a = "SELECT * FROM sensor1";
                cmd.CommandText = a;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lsbVS1.Items.Add(double.Parse(dr[2].ToString()));
                        VectorS1[inicializador1] = (double.Parse(dr[2].ToString()) - MediaS1);
                        inicializador1++;
                    }
                }
                dr.Close();
                cn.Close();

                //Restas del sensor2
                string b = "SELECT * FROM sensor2";
                cmd.CommandText = b;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lsbVS2.Items.Add(double.Parse(dr[2].ToString()));
                        VectorS2[inicializador2] = (double.Parse(dr[2].ToString()) - MediaS2);
                        inicializador2++;
                    }
                }
                dr.Close();
                cn.Close();

                //Restas del sensor3
                string c = "SELECT * FROM sensor3";
                cmd.CommandText = c;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lsbVS3.Items.Add(double.Parse(dr[2].ToString()));
                        VectorS3[inicializador3] = (double.Parse(dr[2].ToString()) - MediaS3);
                        inicializador3++;
                    }
                }
                dr.Close();
                cn.Close();

                for (int i = 0; i < Id; i++)
                {
                    lsbMediaS1.Items.Add(VectorS1[i]);
                    lsbMediaS2.Items.Add(VectorS2[i]);
                    lsbMediaS3.Items.Add(VectorS3[i]);
                    this.GraficaPoligonal.Series["Racha1"].Points.AddXY(i, VectorS1[i]);   // X=Marca de Clase y Y=Frecuencia
                    this.GraficaPoligonal2.Series["Racha2"].Points.AddXY(i, VectorS2[i]);   // X=Marca de Clase y Y=Frecuencia
                    this.GraficaPoligonal3.Series["Racha3"].Points.AddXY(i, VectorS3[i]);   // X=Marca de Clase y Y=Frecuencia
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
