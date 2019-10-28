using System;

namespace Aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("<<<<<<<<<<<<< BemVindo(a) ao Gerador de numeros Aleatorios>>>>>>>>>>>>>>>>>");
            Console.ResetColor();


            

            int[] inici = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Random ale = new Random();

            for (int i = 0; i < 10; i++)
            {,0
            
                inici[i] = ale.Next(1, 1000);
            }
            foreach (int b in inici)
            {
                
            }
            System.Console.WriteLine("====================PARES===============================");
            for (int i = 0; i < 10; i++)
            {
                if (inici[i] % 2 == 0)
                {
                    System.Console.WriteLine($"{inici[i]}"  );
                }
                else
                {
                    
                }
            }
            System.Console.WriteLine("=======================IMPARES===========================");
            for (int i = 0; i < 10; i++)
            {
                if (inici[i] % 2 != 0)
                {
                    System.Console.WriteLine($" {inici[i]}");
                }
            }


        }
    }
}
