using System;

namespace CaixaEletrronica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------------BemVindo(a) ao Caixa Eletronico --------- XD");
            Console.ResetColor();




            double[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
            int[] saque = new int[cedulas.Length];
            System.Console.WriteLine("Digite o Valor do saque:");
            double valor = double.Parse(Console.ReadLine());

            int resto = 0;
            do
            {
                if (valor >= cedulas[resto])
                {
                    valor = valor - cedulas[resto];
                    saque[resto] = saque[resto] + 1;
                }
                if (valor < cedulas[resto]) resto++;

            } while (valor != 0);
            for (int i = 0; i < saque.Length; i++)
                if (saque[i] != 0) System.Console.WriteLine($"Notas de {cedulas[i]}: {saque[i]}");




        }
    }
}
