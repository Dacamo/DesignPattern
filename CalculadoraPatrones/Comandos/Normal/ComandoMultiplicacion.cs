﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Comandos
{
    public class ComandoMultiplicacion : ComandoBase<double>
    {
        public ComandoMultiplicacion(double valor, Calculadora<double> calculadora) : base(valor, calculadora)
        {
        }

        

        public override void Ejecutar()
        {
            Calculadora.Actualizar(Calculadora.Resultado * Valor);
        }
    }
}
