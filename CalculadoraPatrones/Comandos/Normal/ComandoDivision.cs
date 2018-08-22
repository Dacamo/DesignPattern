using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Comandos
{
    public class ComandoDivision : ComandoBase<double>
    {
        public ComandoDivision(double valor, Calculadora<double> calculadora) : base(valor, calculadora)
        {
        }

        public override void Deshacer()
        {
            Calculadora.Actualizar(Calculadora.Resultado * Valor);
        }

        public override void Ejecutar()
        {
            Calculadora.Actualizar(Calculadora.Resultado / Valor);
        }
    }
}
