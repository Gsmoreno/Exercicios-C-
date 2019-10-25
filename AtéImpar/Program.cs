using System;

namespace AtéImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            double nmr = 0;

            System.Console.WriteLine("Digite um numero para ser o limitador do numeros impares: ");
            nmr = int.Parse(Console.ReadLine());
            System.Console.WriteLine("============================================================");

            for (int i = 1; i <= nmr; i += 2 )
            {
                System.Console.WriteLine(i);
            }
            
        }
    }
}
