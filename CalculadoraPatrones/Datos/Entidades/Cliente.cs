using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Datos
{
    class Cliente
    {
        private int id;
        private String usuario;
        private String contrasena;

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }

    
}
