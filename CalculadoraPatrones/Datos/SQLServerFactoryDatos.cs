using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Datos
{
    class SQLServerFactoryDatos : AbstractFactory
    {
        
        public override IClienteDatos crearClienteDatos()
        {
            return new ClienteSQLServerDatos();
        }
    }
}
