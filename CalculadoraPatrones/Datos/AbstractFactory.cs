using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Datos
{
    abstract class AbstractFactory
    {
        public static AbstractFactory crearFactoria()
        {
            AbstractFactory factoria = new SQLServerFactoryDatos();
            Console.WriteLine("Factoria creada SQLServerFactory");
            return factoria;
        }

        public abstract IClienteDatos crearClienteDatos();
        
        
        

    }
}
