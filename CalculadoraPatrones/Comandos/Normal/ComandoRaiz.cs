﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Comandos.Normal
{
    class ComandoRaiz : ComandoBase<double>
    {
        public ComandoRaiz(double valor, Calculadora<double> calculadora) : base(valor, calculadora)
        {
        }

        

        public override void Ejecutar()
        {
            Calculadora.Actualizar(Math.Pow(Calculadora.Resultado,1/Valor));
        }
    }
}
