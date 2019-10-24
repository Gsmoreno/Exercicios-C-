using System;

namespace Crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;

            Console.WriteLine("<_______.Ordem Crescente.______>");
            System.Console.WriteLine("Digite um numero: ");
            num1 = double.Parse( Console.ReadLine());
            System.Console.WriteLine("Digite outro numero: ");
            num2 = double.Parse( Console.ReadLine());
            System.Console.WriteLine("Digite outro numero: ");
            num3 = double.Parse( Console.ReadLine());
            System.Console.WriteLine("========================");

            if ((num1 > num2) && (num1 > num3) && (num2 > num3))
            {
                System.Console.WriteLine($"{num3}");
                System.Console.WriteLine($"{num2}");
                System.Console.WriteLine($"{num1}");
            }else if((num2 > num1) && (num2 > num3) && (num1 > num3)){
                System.Console.WriteLine($"{num3}");
                System.Console.WriteLine($"{num1}");
                System.Console.WriteLine($"{num2}");
            }else if((num3 > num1) && (num3 > num2) && (num1 > num2)){
                System.Console.WriteLine($"{num2}");
                System.Console.WriteLine($"{num1}");
                System.Console.WriteLine($"{num3}");
            }else if ((num1 > num2) && (num1 > num3) && (num3 > num2))
            {
                System.Console.WriteLine($"{num2}");
                System.Console.WriteLine($"{num3}");
                System.Console.WriteLine($"{num1}");
            }else if((num2 > num1) && (num2 > num3) && (num3 > num1)){
                System.Console.WriteLine($"{num1}");
                System.Console.WriteLine($"{num3}");
                System.Console.WriteLine($"{num2}");
            }else if((num2 > num1) && (num2 > num3) && (num1 > num3))
            {
                System.Console.WriteLine($"{num1}");
                System.Console.WriteLine($"{num2}");
                System.Console.WriteLine($"{num3}");
            }else
            {
                System.Console.WriteLine("Numeros invalidos.");
            }
        }
    }
}
