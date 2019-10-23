using System;

namespace Retangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double bose = 0;
            double alt = 0;
            

            System.Console.WriteLine("========== Bem vindo ao medidor de Area(Retangulos)============");
            System.Console.WriteLine("Digite o valor da base: ");
            bose = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da altura: ");
            alt = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"A area desse retangulo é : {bose * alt}");
            System.Console.WriteLine($"O perimetro desse retangulo é : {(bose * 2) + (alt * 2)}");
            

            System.Console.WriteLine($"A diagonal mede : { Math.Sqrt((bose * bose) + (alt * alt))}   " );

            
            
            
            
        }
    }
}
