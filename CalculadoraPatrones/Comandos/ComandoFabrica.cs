using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Comandos
{
    public class ComandoFabrica<T>
    {
        public ComandoBase<T> ObtenerComando(Calculadora<T> calculadora, Operacion operacion, T valor)
        {
            if (typeof(T) == typeof(double))
            {
                var calculadoraDoubles = calculadora as Calculadora<double>;
                double valorDouble = (double)(object)valor;

                switch (operacion)
                {
                    case Operacion.Suma:
                        return new ComandoSuma(valorDouble, calculadoraDoubles) as ComandoBase<T>;
                    case Operacion.Resta:
                        return new ComandoResta(valorDouble, calculadoraDoubles) as ComandoBase<T>;
                    case Operacion.Multiplicacion:
                        return new ComandoMultiplicacion(valorDouble, calculadoraDoubles) as ComandoBase<T>;
                    case Operacion.Division:
                        return new ComandoDivision(valorDouble, calculadoraDoubles) as ComandoBase<T>;
                    case Operacion.entero:
                        return new ComandoEntero(valorDouble, calculadoraDoubles) as ComandoBase<T>;
                    default:
                        throw new Exception("Operacion desconocida");
                }
            }
            else
            {
                var calculadoraFracciones = calculadora as Calculadora<KeyValuePair<int, int>>;
                var valorFraccion = (KeyValuePair<int, int>)(object) valor;

                switch (operacion)
                {
                    case Operacion.Suma:
                        return new ComandoSumaFraccionarios(valorFraccion, calculadoraFracciones) as ComandoBase<T>;
                    case Operacion.Resta:
                        return new ComandoRestaFraccionarios(valorFraccion, calculadoraFracciones) as ComandoBase<T>;
                    case Operacion.Multiplicacion:
                        return new ComandoMultiplicacionFraccionarios(valorFraccion, calculadoraFracciones) as ComandoBase<T>;
                    case Operacion.Division:
                        return new ComandoDivisionFraccionarios(valorFraccion, calculadoraFracciones) as ComandoBase<T>;
                    default:
                        throw new Exception("Operacion desconocida");
                }
            }

            
        }

    }
}
