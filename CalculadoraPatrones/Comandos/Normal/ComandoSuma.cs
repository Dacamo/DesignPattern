using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Comandos
{
    public class ComandoSuma : ComandoBase<double>
    {
        public ComandoSuma(double valor, Calculadora<double> calculadora) : base(valor, calculadora)
        {
        }

        

        public override void Ejecutar()
        {
            Calculadora.Actualizar(Calculadora.Resultado + Valor);
        }
    }
}
