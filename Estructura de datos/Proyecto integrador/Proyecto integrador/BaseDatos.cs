using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //directiva

namespace Proyecto_integrador
{
    class BaseDatos
    {
        MySqlConnection conexion = new MySqlConnection(); //Variable para hacer la conexion
        MySqlCommand comando = new MySqlCommand(); //Variable para hacer comandos

        private string instruccionSql;

        public void Write(double sensor1, double sensor2, double sensor3, double totalS1, double totalS2, double totalS3, bool limite1, bool limite2, bool limite3)
        {
            //Cadena la cual indica a que servidor vamos, que base de datos usaremos, con cual usuario y contraseña
            conexion.ConnectionString = "Server=localhost;Database=proyectointegrador4to;User id=root;Password=";
            //Cadenas con instrucciones
            instruccionSql = "INSERT INTO sensor1(FlujoMinuto, Total, Fecha, DentroLimite) VALUES (" + sensor1 + "," + totalS1 + ",'" + DateTime.Now.ToString() + "'," + limite1 + ")";
            dosomething(instruccionSql);
            instruccionSql = "INSERT INTO sensor2(FlujoMinuto, Total, Fecha, DentroLimite) VALUES (" + sensor2 + "," + totalS2 + ",'" + DateTime.Now.ToString() + "'," + limite2 + ")";
            dosomething(instruccionSql);
            instruccionSql = "INSERT INTO sensor3(FlujoMinuto, Total, Fecha, DentroLimite) VALUES (" + sensor3 + "," + totalS3 + ",'" + DateTime.Now.ToString() + "'," + limite3 + ")";
            dosomething(instruccionSql);
        }
        
        private void dosomething(string instruccionSql)
        {
            conexion.Open(); //Se conecta con el servidor
            comando.CommandText = instruccionSql; //Recibe la instruccion
            comando.Connection = conexion; //Permite realizar operaciones en l base de datos
            comando.ExecuteNonQuery(); //Ejecuta la instruccion
            conexion.Close(); //Cierra la coneccion con el servidor
        }
    }
}
