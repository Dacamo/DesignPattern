using CalculadoraPatrones.Datos;
using CalculadoraPatrones.Datos.Conexion;
//using CalculadoraPatrones.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CalculadoraPatrones
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstractFactory factoria = AbstractFactory.crearFactoria();
            Cliente usuario = new Cliente();
            usuario.Usuario = "idacamo";
            usuario.Contrasena = "12";
            factoria.crearClienteDatos().registrar(usuario);


            usuario.Usuario = "no se";


            if (factoria.crearClienteDatos().loguear(usuario))
            {
                factoria.crearClienteDatos().registrar_ingreso(usuario, 1);

            }
            else {
                factoria.crearClienteDatos().registrar_ingreso(usuario, 0);
            }
            
            
            InvokerCalculadora<double> invokerCalculadora = 
                new InvokerCalculadora<double>(new Calculadora<double>(0));


            //Sumar, restar dos numeros
            invokerCalculadora.Ejecutar(Operacion.Suma, 1220);
            invokerCalculadora.Ejecutar(Operacion.Suma, 100);
            Console.WriteLine(invokerCalculadora.Calculadora.Resultado);
            invokerCalculadora.Ejecutar(Operacion.Resta, 100);
            invokerCalculadora.Ejecutar(Operacion.Resta, 1000);
            Console.WriteLine(invokerCalculadora.Calculadora.Resultado);

            //probar numero es entero
            invokerCalculadora.Ejecutar(Operacion.entero, 3250);
            Console.WriteLine(invokerCalculadora.Calculadora.Resultado);
            
            //probar numero no es entero
            invokerCalculadora.Ejecutar(Operacion.entero, 1.51);
            Console.WriteLine(invokerCalculadora.Calculadora.Resultado);

            //calculadora de fracciones
            InvokerCalculadora<KeyValuePair<int, int>> invokerCalculadora2 =
                new InvokerCalculadora<KeyValuePair<int, int>>(new Calculadora<KeyValuePair<int, int>>(new KeyValuePair<int, int>(1,1)));
            invokerCalculadora2.Ejecutar(Operacion.Suma, new KeyValuePair<int, int>(3,2));
            invokerCalculadora2.Ejecutar(Operacion.Resta, new KeyValuePair<int, int>(2, 2));

            Console.WriteLine($"{invokerCalculadora2.Calculadora.Resultado.Key} {invokerCalculadora2.Calculadora.Resultado.Value}");

            
            Console.ReadKey();

           
        }
    }
}
