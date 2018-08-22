using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones
{
    /// <summary>
    /// Commmand
    /// </summary>
    public abstract class ComandoBase<T>
    {
        public T Valor { get; private set; }        

        public Calculadora<T> Calculadora { get; private set; }

        public abstract void Ejecutar();

        

        public ComandoBase(T valor, Calculadora<T> calculadora)
        {
            Valor = valor;
            Calculadora = calculadora;
        }
    }
}
