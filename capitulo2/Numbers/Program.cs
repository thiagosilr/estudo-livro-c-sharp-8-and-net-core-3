using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Número inteiros positivos sem sinal (sem número negativos).
            uint inteirosPositivos = 0;

            // Número inteiros positivos e negativos.
            int inteirosPositivosNegativos = -23;

            Console.WriteLine(
                $@"O tipo int utiliza {sizeof(int)} bytes de memória e 
                suportam números de {int.MinValue:N0} até {int.MaxValue:N0}.");
            
            Console.WriteLine(
                $@"O tipo float utiliza {sizeof(float)} bytes de memória e
                suportam números de {float.MinValue:N0} até {float.MaxValue:N0}.");

            Console.WriteLine(
                $@"O tipo double utiliza {sizeof(double)} bytes de memória e
                suportam números de {double.MinValue:N0} até {double.MaxValue:N0}.");
            
            Console.WriteLine(
                $@"O tipo decimal utiliza {sizeof(decimal)} bytes de memória e
                suportam números de {decimal.MinValue:N0} até {decimal.MaxValue:N0}.");

            // Anotação decimal para não ter necessidade de deixar explicito o tipo da variável.
            var a = 10.5M;
        }
    }
}
