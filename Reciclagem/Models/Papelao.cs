using System;
using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Papel
    {
        

        public void Lixao()
        {
            
            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Papelao deve ser jogado na lixeira AZUL");
            Console.ResetColor();
        }
    }
}