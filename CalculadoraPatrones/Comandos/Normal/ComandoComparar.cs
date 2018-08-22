using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Comandos.Normal
{
    public class ComandoComparar : ComandoBase<Double>
    {

        public ComandoComparar(double valor, Calculadora<double> calculadora) : base(valor, calculadora)
        {
        }

        

        public override void Ejecutar()
        {
            // 1 indica que no es mayor
            // 0 indica que si es mayor
            if (Valor> Calculadora.Resultado)
            {
                Calculadora.Actualizar(0);
            }
            else
            {
                Calculadora.Actualizar(1);
            }
        }
    }
}
