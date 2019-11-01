using System;
using System.Collections.Generic;
using Zoologico.Models;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcao = 0;

            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine("________________________________________________");
            Console.WriteLine("|||||||||||||BEM VINDO AO ZOOLOGICO!||||||||||||");
            System.Console.WriteLine("________________________________________________");
            Console.ResetColor();

            foreach (var item in TodosAnimais.Animais.Values)
            {
                System.Console.WriteLine($"{++opcao} . {item.GetType().Name} ");
            }
            System.Console.WriteLine("Digite o codigo do Animal: ");
            opcao = int.Parse(Console.ReadLine());

            
            
            








        }
    }
}
