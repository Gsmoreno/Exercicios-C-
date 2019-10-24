using System;

namespace OrdemAlfabetica
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;

            System.Console.WriteLine("____________________.Ordem Afabetica._______________");
            System.Console.WriteLine("Digoite um nome: ");
            nome1 = Console.ReadLine();
            System.Console.WriteLine("Digite outro nome: ");
            nome2 = Console.ReadLine();
            
            int com = String.Compare(nome1, nome2);

            if (com > 0)
            {
                System.Console.WriteLine($" 1- {nome2}  2- {nome1}");
            }else if(com == 0){
                System.Console.WriteLine("Os nomes sao iguais");
            }else{
                System.Console.WriteLine($" 1- {nome1}  2- {nome2}");
            }
            
            
        }
    }
}
