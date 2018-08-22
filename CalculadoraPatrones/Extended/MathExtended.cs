using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPatrones.Extended
{
    public static class MathExtended
    {
        public static int MaximoComunDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (true)
            {
                int remainder = a % b;
                if (remainder == 0) return b;
                a = b;
                b = remainder;
            }
        }

        public static int MinimoComunMultiplo(int a, int b)
        {
            return a * b / MaximoComunDivisor(a, b);
        }
    }
}
