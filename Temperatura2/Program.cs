using System;

namespace Temperatura2
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = 0;
            double F = 0;
            System.Console.WriteLine("_____________Bem vindo(a) ao conversor de Temperatura_____________");
            System.Console.WriteLine("Digite a temperatura a ser convertida: ");
            C = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"A temperatura em Fahrenheit é: {F =(C * 9/5) + (32)}");
            

        }
    }
}
