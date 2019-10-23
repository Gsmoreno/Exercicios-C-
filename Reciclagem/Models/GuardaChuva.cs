using System;
using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : DescarteEspecial
    {
        

        public void Lixao()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Guarda Chuva deve ser jogado na lixeira CINZA");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ResetColor();
            
        }
    }
}