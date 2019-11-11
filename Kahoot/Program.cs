using System;

namespace Kahoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("_____________.KAHOOT DA SORTE.______________");
            Console.ResetColor();

            int[,] matrix = {
                {10, 15, 48},
                {56, 97, 77},
                {2, 100, 33}
            };

            int soma = 10 + 15 + 48 + 56 + 97 + 77 + 2 + 100 + 33;

            System.Console.WriteLine(soma);
        }
    }
}
