using System;
using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPET : Plastico
    {
        

        public void Lixao()
        {
            
            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Garrafa PET deve ser jogado na lixeira VERMELHA");
            Console.ResetColor();
        }
    }
}