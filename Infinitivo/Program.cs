using System;

namespace Infinitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("||B|E|M|-|V|I|N|D|O|(|A|)|A|O||C|L|A|S|S|F|I|C|A|D|O|R||D|E||I|N|F|I|N|I|T|I|V|O||");
            Console.ResetColor();

            string verbo;

            System.Console.WriteLine("Digite um verbo no INFINITIVO: ");
            verbo = Console.ReadLine();
            
            string y = verbo.Substring(verbo.Length-2, 2);

            switch (y)
            {
                case "ar":
                    System.Console.WriteLine($"O Verbo {verbo} é da 1ª - conjugação. ");
                    break;
                case "er":
                    System.Console.WriteLine($"O Verbo {verbo} é da 2ª - conjugação. ");
                    break;
                case "ir":
                    System.Console.WriteLine($"O Verbo {verbo} é da 3ª - conjugação. ");
                    break;
                default:
                    System.Console.WriteLine("Esse verbo nao esta no Infinitivo");
                    break;
            }
        }
    }
}
