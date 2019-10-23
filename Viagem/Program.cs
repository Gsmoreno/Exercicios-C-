using System;

namespace Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia = 0;
            double tempo = 0;
            double velo = 0;
            double litrosU = 0;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("°°°°°°°°°° .Bem Vindo(a) ao Calcula de Viagem. °°°°°°°°°°°");
            Console.ResetColor();
            System.Console.WriteLine("Digite o tempo gasto na viagem: ");
            tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a velocidade media durante a viagem: ");
            velo = double.Parse(Console.ReadLine());
            distancia = tempo * velo;
            litrosU = distancia / 12;
            System.Console.WriteLine($"A quantidade de litros gastos durante a viagem foi de: {litrosU}");
            System.Console.WriteLine($"A velocidade foi de : {velo} km");
            System.Console.WriteLine($"A distancia percorrida foi de: {distancia}");
            System.Console.WriteLine($"O tempo gasto na viagem foi de: {tempo} ");
            
        }
    }
}
