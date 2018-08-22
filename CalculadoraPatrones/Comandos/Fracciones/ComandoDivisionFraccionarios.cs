using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Comandos
{
    public class ComandoDivisionFraccionarios : ComandoBase<KeyValuePair<int, int>>
    {
        public ComandoDivisionFraccionarios(KeyValuePair<int, int> valor, Calculadora<KeyValuePair<int, int>> calculadora) : base(valor, calculadora)
        {
        }

        public override void Deshacer()
        {
            var resultado = new KeyValuePair<int, int>(
                Calculadora.Resultado.Key * Valor.Key,
                Calculadora.Resultado.Value * Valor.Value);
            Calculadora.Actualizar(resultado);
        }

        public override void Ejecutar()
        {
            var resultado = new KeyValuePair<int, int>(
                Calculadora.Resultado.Key * Valor.Value,
                Calculadora.Resultado.Value * Valor.Key);
            Calculadora.Actualizar(resultado);
        }
    }
}
