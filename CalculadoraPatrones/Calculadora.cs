using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones
{
    /// <summary>
    /// Receiver -> Receptor
    /// </summary>
    public class Calculadora<T>
    {
        public T Resultado { get; private set; }
        
        public void Actualizar(T nuevoResultado)
        {
            Resultado = nuevoResultado;
        }

        public Calculadora(T valorInicial)
        {
            Resultado = valorInicial;
        }
    }
}
