using System;
using System.Collections.Generic;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcao = 0;
            var jaula = 0;

            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine("________________________________________________");
            Console.WriteLine("|||||||||||||BEM VINDO AO ZOOLOGICO!||||||||||||");
            System.Console.WriteLine("________________________________________________");
            Console.ResetColor();

            foreach (var item in TodosAnimais.Animais.Values)
            {
                System.Console.WriteLine($"{++opcao} . {item.GetType().Name} ");
            }
            System.Console.WriteLine("Digite o codigo do Animal a ser alocado: ");
            opcao = int.Parse(Console.ReadLine());

            System.Console.WriteLine("=========================================================");

            foreach (var item in Tudo.Presos.Values)
            {
                System.Console.WriteLine($"{++jaula} . {item.GetType().Name} ");
            }
            System.Console.WriteLine("Agora digite em qual jaula o animal deve ficar: ");
            jaula = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("O animal foi alocado");




            
            
            








        }
    }
}
