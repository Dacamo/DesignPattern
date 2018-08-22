using CalculadoraPatrones.Extended;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Comandos
{
    public class ComandoSumaFraccionarios : ComandoBase<KeyValuePair<int, int>>
    {
        public ComandoSumaFraccionarios(KeyValuePair<int, int> valor, Calculadora<KeyValuePair<int, int>> calculadora) : base(valor, calculadora)
        {
        }

        public override void Deshacer()
        {
            var mcd = MathExtended.MinimoComunMultiplo(
                Calculadora.Resultado.Value,
                Valor.Value);

            var resultado = new KeyValuePair<int, int>(
                Calculadora.Resultado.Key * mcd / Calculadora.Resultado.Value - Valor.Key * mcd / Valor.Value,
                mcd);

            Calculadora.Actualizar(resultado);
        }

        public override void Ejecutar()
        {
            var mcd = MathExtended.MinimoComunMultiplo(
                Calculadora.Resultado.Value,
                Valor.Value);

            var resultado = new KeyValuePair<int, int>(
                Calculadora.Resultado.Key * mcd / Calculadora.Resultado.Value + Valor.Key * mcd / Valor.Value,
                mcd);

            Calculadora.Actualizar(resultado);
        }
    }
}
