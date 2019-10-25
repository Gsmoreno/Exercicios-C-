using System;

namespace ClassificaçaoTri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("^^^^^^^^ BemVindo(a) ao Classificador de Triangulos ^^^^^^^^");
            Console.ResetColor();

            double lad1 = 0;
            double lad2 = 0;
            double lad3 = 0;

            System.Console.WriteLine("Digite um lado do triangulo: ");
            lad1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o outro lado do triangulo: ");
            lad2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o outro lado do triangulo: ");
            lad3 = double.Parse(Console.ReadLine());

            if((lad1 + lad2) > lad3 && (lad3 + lad2 ) > lad1){

                if ((lad1 == lad2) && (lad2 == lad3))
                {
                    System.Console.WriteLine("Esse Triangulo é Equilatero!");
                }
                else if ((lad1 == lad2) && (lad2 != lad3) || (lad1 == lad3) && (lad3 != lad2) || (lad2 == lad3) && (lad3 != lad1))
                {
                    System.Console.WriteLine("Esse Triangulo é Isoceles");
                }
                else if ((lad1 != lad2) && (lad1 != lad3) && (lad2 != lad3))
                {
                    System.Console.WriteLine("Esse Triangulo é Escaleno ");
                }
                else
                {
                    System.Console.WriteLine("Lados invalidos!");
                }

            }else
            {
                System.Console.WriteLine("O triangulo é invalido");
            }

        }
    }
}
