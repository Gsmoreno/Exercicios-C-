using System;

namespace MatrizValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___________.Bem Vindo(a) listagem de valores.____________");

            int nmr = 0; 

            System.Console.WriteLine($"Digite a quantidade de numeros que voce quer que seja digitado: ");
            nmr = int.Parse(Console.ReadLine());

            int[] numeros = new int [nmr];
            for (int i = 0; i < nmr; i++)
            {
            Console.WriteLine($"Digite o {i + 1}º numero: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int a = 0; a < nmr; a++)
            {
                System.Console.WriteLine($"Os numeros que voce digitou foram: {numeros[a]}");
            }


            
        }
    }
}
