using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CalculadoraPatrones.Datos.Conexion
{
    class ConexionDB
    {
       
        private static SqlConnection con = null;
        public static SqlConnection getConnection()
        {
            if (con == null)
            {
                
                con = new SqlConnection("Data Source=DESKTOP-56LBS8C\\SQLEXPRESS; Initial Catalog=Db;Integrated Security=True");
                con.Open();
                Console.WriteLine("Se crea nueva conexion");
            }
            return con;

        }
    }
}
