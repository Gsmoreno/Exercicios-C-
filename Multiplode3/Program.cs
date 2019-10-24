using System;

namespace Multiplode3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nmr = 0;

            System.Console.WriteLine("Digite um numero para ver se ele é multiplo de 3: ");
            nmr = double.Parse(Console.ReadLine());

            if ((nmr % 3) == 0 )
            {
                System.Console.WriteLine($"O numero {nmr} é mutiplo de 3 ");
            }else
            {
                System.Console.WriteLine($"O numero {nmr} não é mutiplo de 3");
            }
            
        }
    }
}
