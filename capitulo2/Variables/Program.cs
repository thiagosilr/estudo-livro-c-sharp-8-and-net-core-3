using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variável dinâmica, o tipo é decidido em tempo de execução.
            dynamic anotherName = "Ahmed";
            var length = anotherName.Length;

            // Uso de declaração implecita para os tipos mais básicos.
            var population = 33333; // Int
            var weight = 1.88; // Double
            var ditance = 1222.44F; // Float
            var price = 4.99M; // Decimal
            var fruit = "Apples"; // String
            var letter = 'Z'; // Char
            var happy = true; // Bool
        }
    }
}
