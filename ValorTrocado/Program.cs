using System;

namespace ValorTrocado
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;

            System.Console.WriteLine("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o valor de B: ");
            B = double.Parse(Console.ReadLine());
            C = A;
            D = B;
            
            System.Console.WriteLine($" A = {A = D}");
            System.Console.WriteLine($" B = {B = C}");
            
            


        }
    }
}
