using System;

namespace Planetas
{
    class Program
    {
        static void Main(string[] args)
        {
            double Mercurio = 0.37;
            double Venus = 0.88;
            double Marte = 0.38;
            double Jupiter = 2.64;
            double Saturno = 1.15;
            double Urano = 1.17;
            double peso = 0;
            double opcao = 0;
            double abc  = 0; 

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("======== .BemVindo(a) ao conversor Universal. ============");
            System.Console.WriteLine("                   1 - Mercurio                           ");
            System.Console.WriteLine("                   2 - Venus                              ");
            System.Console.WriteLine("                   3 - Marte                              ");
            System.Console.WriteLine("                   4 - Jupiter                            ");
            System.Console.WriteLine("                   5 - Saturno                            ");
            System.Console.WriteLine("                   6 - Urano                              ");
            System.Console.WriteLine("==========================================================");
            Console.ResetColor();

            System.Console.WriteLine("Digite o seu peso na Terra: ");
            peso = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite o numero do planeta: ");
            opcao = double.Parse(Console.ReadLine());
            

            
            switch (opcao)
            {
                case 1:
                     abc = (peso/10) * Mercurio;
                    System.Console.WriteLine($"Seu peso em Mercurio é: {abc} ");
                    break;
                case 2:
                    abc = (peso/10) * Venus;
                    System.Console.WriteLine($"Seu peso em Venus é: {abc}");
                    break;
                case 3:
                    abc = (peso/10) * Marte;
                    System.Console.WriteLine($"Seu peso em Venus é: {abc}");   
                    break;
                case 4:
                    abc = (peso/10) * Jupiter;
                    System.Console.WriteLine($"Seu peso em Jupiter é: {abc}");
                    break;
                case 5: 
                    abc = (peso/10) * Saturno;
                    System.Console.WriteLine($"Seu peso em Saturno é: {abc}");
                    break;
                case 6:
                    abc = (peso/10) * Urano;
                    System.Console.WriteLine($"Seu peso em Urano é: {abc}");
                    break;
                
            }
        }
    }
}
