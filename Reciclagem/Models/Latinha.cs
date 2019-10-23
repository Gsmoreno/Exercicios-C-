using System;
using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class Latinha : Metal
    {
        

        public void Lixao()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            
            System.Console.WriteLine("Latinha deve ser jogado na lixeira AMARELA");
            Console.ResetColor();
            
        }
    }
}