using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BDConexion
{
    public class conexionBD
    {
        private string cadena = @"Data Source=GT-MGUZMAN-NBK\SQLEXPRESS;Initial Catalog=BDVENTAS_5;Integrated Security=True";

        private SqlConnection conexion;

        public SqlConnection conectarBD()
        {
            conexion = new SqlConnection(cadena);
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            else {
                conexion.Open();
                Console.WriteLine("Version del Servidor: {0}", conexion.ServerVersion);
                Console.WriteLine("Estado: {0}", conexion.State);
                
            }
            return conexion;
        }


    }
}
