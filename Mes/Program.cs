using System;

namespace Mes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("||B|E|M|-|V|I|N|D|O|(|A|)|A|O||C|L|A|S|S|F|I|C|A|D|O|R||D|E||M|Ê|S||");
            Console.ResetColor();

            int nmr = 0;

            System.Console.WriteLine("Digite um numero de 1 a 12 correspondente aos Meses");
            nmr = int.Parse(Console.ReadLine());
            
            switch (nmr)
            {
                case 1:
                    System.Console.WriteLine("O Mês 1 é Janeiro.");
                    break;
                case 2:
                    System.Console.WriteLine("O Mês 2 é Fevereiro.");
                    break;
                case 3:
                    System.Console.WriteLine("O Mês 3 é Março.");
                    break;
                case 4:
                    System.Console.WriteLine("O Mês 4 é Abril.");
                    break;
                case 5:
                    System.Console.WriteLine("O Mês 5 é Maio.");
                    break;
                case 6:
                    System.Console.WriteLine("O Mês 6 é Junho.");
                    break;
                case 7:
                    System.Console.WriteLine("O Mês 7 é Julho.");
                    break;
                case 8:
                    System.Console.WriteLine("O Mês 8 é Agosto.");
                    break;
                case 9:
                    System.Console.WriteLine("O Mês 9 é Setembro.");
                    break;
                case 10:
                    System.Console.WriteLine("O Mês 10 é Outubro.");
                    break;
                case 11:
                    System.Console.WriteLine("O Mês 11 é Novembro.");
                    break;
                case 12:
                    System.Console.WriteLine("O Mês 12 é Dezembro.");
                    break;
                default:
                    System.Console.WriteLine("O Mes que corresponde a esse numero Nao EXISTE! ");
                    break;
                
            }
            
        }
    }
}
