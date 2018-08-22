using CalculadoraPatrones.Comandos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones
{
    public class InvokerCalculadora<T>
    {
        public List<ComandoBase<T>> HistoricoCommandos { get; private set; }

        public Calculadora<T> Calculadora { get; private set; }

        public ComandoFabrica<T> ComandoFabrica { get; private set; }

        public InvokerCalculadora(Calculadora<T> calculadora)
        {
            Calculadora = calculadora;
            HistoricoCommandos = new List<ComandoBase<T>>();
            ComandoFabrica = new ComandoFabrica<T>();
        }

        public void Ejecutar(Operacion operacion, T valor)
        {
            var comando = ComandoFabrica.ObtenerComando(Calculadora, operacion, valor);
            HistoricoCommandos.Add(comando);
            comando.Ejecutar();
        }
    }
}
