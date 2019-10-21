using System;
using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class Garrafa : Vidro
    {
        public void Lixao()
        {
            System.Console.WriteLine("Garrafa deve ser jogado na lixeira VERDE");
            
        }
    }
}