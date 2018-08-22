using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Comandos
{
    public class ComandoEntero : ComandoBase<double>
    {
        public ComandoEntero(double valor, Calculadora<double> calculadora) : base(valor, calculadora)
        {
        }

        

        public override void Ejecutar()
        {
            // 1 indica que no es entero
            // 0 indica que si es entero
            double resul = Valor % 1;
            if (resul == 0)
            {
                Calculadora.Actualizar(0);
            }
            else {
                Calculadora.Actualizar(1);
            }
            

        }
    }
}
