using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CalculadoraPatrones.Datos.Conexion;

namespace CalculadoraPatrones.Datos
{
    class ClienteSQLServerDatos : IClienteDatos
    {
        //SqlConnection connection;
        
        public void registrar(Cliente entidad)
        {
            if (!this.consultar_usuario(entidad))
            {
                SqlCommand command = new SqlCommand("INSERT INTO USUARIO(usuario, contrasena) VALUES(@usuario, @contrasena)", ConexionDB.getConnection());
                command.Parameters.AddWithValue("usuario", entidad.Usuario);
                command.Parameters.AddWithValue("contrasena", entidad.Contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                int filasAfectadas = command.ExecuteNonQuery();
                Console.WriteLine("Registro Exitoso");
            }
            else {
                Console.WriteLine("Ya existe este usuario");
            }
        }

        public bool loguear(Cliente entidad)
        {
            SqlCommand command = new SqlCommand("SELECT * from usuario WHERE usuario=@user AND contrasena =@pass", ConexionDB.getConnection());
            command.Parameters.AddWithValue("user", entidad.Usuario);
            command.Parameters.AddWithValue("pass", entidad.Contrasena);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)

            {
                Console.WriteLine("Ingreso Correcto");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool consultar_usuario(Cliente entidad)
        {
            SqlCommand command = new SqlCommand("SELECT * from usuario WHERE usuario=@user", ConexionDB.getConnection());
            command.Parameters.AddWithValue("user", entidad.Usuario);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)

            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool registrar_ingreso(Cliente entidad, int exito)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Ingresos(Usuario, Fecha, exito) VALUES(@user, @fecha, @exito)", ConexionDB.getConnection());
            command.Parameters.AddWithValue("user", entidad.Usuario);
            command.Parameters.AddWithValue("fecha", DateTime.Now);
            command.Parameters.AddWithValue("exito", exito);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            command.ExecuteNonQuery();
            return true;
        }

        public bool registrar_operacion(Cliente entidad, string descripcion)
        {
            SqlCommand command = new SqlCommand("INSERT INTO operacion(Usuario, Fecha, operacion) VALUES(@user, @fecha, @operacion)", ConexionDB.getConnection());
            command.Parameters.AddWithValue("user", entidad.Usuario);
            command.Parameters.AddWithValue("fecha", DateTime.Now);
            command.Parameters.AddWithValue("operacion", descripcion);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            command.ExecuteNonQuery();
            return true;
        }
    }
}
