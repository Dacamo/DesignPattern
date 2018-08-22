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
            usuario.Usuario = "user";
            usuario.Contrasena = "123asd";
            factoria.crearClienteDatos().registrar(usuario);


            usuario.Usuario = "Cridacamo";
            usuario.Contrasena = "sisas";


            if (factoria.crearClienteDatos().loguear(usuario))
            {
                factoria.crearClienteDatos().registrar_ingreso(usuario, 1);

            }
            else {
                factoria.crearClienteDatos().registrar_ingreso(usuario, 0);
            }

            Console.WriteLine(" ");
            InvokerCalculadora<double> invokerCalculadora = 
                new InvokerCalculadora<double>(new Calculadora<double>(0));


            //Sumar, restar dos numeros
            invokerCalculadora.Ejecutar(Operacion.Suma, 1220);
            invokerCalculadora.Ejecutar(Operacion.Suma, 100);
            Console.WriteLine("Suma-> (0+1220 +100) = " + invokerCalculadora.Calculadora.Resultado);
            invokerCalculadora.Calculadora.Actualizar(0);
            invokerCalculadora.Ejecutar(Operacion.Suma, 2000);
            invokerCalculadora.Ejecutar(Operacion.Resta, 1000);
            Console.WriteLine("Resta-> (0+2000-1000) = " + invokerCalculadora.Calculadora.Resultado);

            //probar numero es entero
            invokerCalculadora.Ejecutar(Operacion.entero, 3250);
            Console.WriteLine("Entero = 0, No entero 1 = "+ 3250 + " es = " + invokerCalculadora.Calculadora.Resultado);
            
            //probar numero no es entero
            invokerCalculadora.Ejecutar(Operacion.entero, 1.51);
            Console.WriteLine("Entero = 0, No entero 1 = " + 1.51 + " es = " + invokerCalculadora.Calculadora.Resultado);
            
            //raiz cuadrada de 100
            invokerCalculadora.Calculadora.Actualizar(100);
            invokerCalculadora.Ejecutar(Operacion.raiz, 2);
            Console.WriteLine("Raiz cuadrada de 100= " + invokerCalculadora.Calculadora.Resultado);

            //potencia
            invokerCalculadora.Calculadora.Actualizar(5);
            invokerCalculadora.Ejecutar(Operacion.potencia, 2);
            Console.WriteLine("5 elevado a la 2= " + invokerCalculadora.Calculadora.Resultado);

            //comparar numeros "se compara 2 con el 100"
            invokerCalculadora.Calculadora.Actualizar(100);
            invokerCalculadora.Ejecutar(Operacion.comparar, 2);
            Console.WriteLine("2>100? = " +invokerCalculadora.Calculadora.Resultado);

            //calculadora de fracciones
            InvokerCalculadora<KeyValuePair<int, int>> invokerCalculadora2 =
                new InvokerCalculadora<KeyValuePair<int, int>>(new Calculadora<KeyValuePair<int, int>>(new KeyValuePair<int, int>(0,1)));
            
            //suma de dos fracciones
            invokerCalculadora2.Ejecutar(Operacion.Suma, new KeyValuePair<int, int>(3,2));
            invokerCalculadora2.Ejecutar(Operacion.Suma, new KeyValuePair<int, int>(2, 2));

            Console.WriteLine($"{invokerCalculadora2.Calculadora.Resultado.Key} {invokerCalculadora2.Calculadora.Resultado.Value}");

            
            Console.ReadKey();

           
        }
    }
}
