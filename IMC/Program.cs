using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("_________ .Calculando o IMC. _______");
            Console.ResetColor();

            double peso = 0;
            double alt = 0;
            string nome;
            double imc = 0;

            System.Console.WriteLine("Digite o  nome do paciente: ");
            nome = Console.ReadLine();
            System.Console.WriteLine("Digite o  peso(Kg) dele: ");
            peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a altura(M) dele: ");
            alt = double.Parse(Console.ReadLine());

            imc = peso/(alt * alt);

            if (imc < 20)
            {
                System.Console.WriteLine($"O paciente {nome} esta abaixo do peso");
            }else if((imc  == 20) || (imc <= 25)){
                System.Console.WriteLine($"O paciente {nome} esta normal");
            }else if((imc > 25) || (imc <= 30)){
                System.Console.WriteLine($"O paciente {nome} esta excesso de peso");
            }else if((imc > 30) || (imc <= 35 )){
                System.Console.WriteLine($"O paciente {nome} esta obeso");
            }
            else
            {
                System.Console.WriteLine($"O paciente {nome} esta na obesidade morbida");
            }
        
                
            
            System.Console.WriteLine($"Seu IMC é {imc}");

        }
    }
}
