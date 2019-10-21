using System.Collections.Generic;

namespace EscolaDeRock.Models
{
    public class Deposito
    {
        public static Dictionary<int, InstrumentoMusical> Instrumentos = new Dictionary<int, InstrumentoMusical>
        {
            {1, new Baixo()},
            {2, new Baixo()}, 
            {3, new Baixo()},
            {4, new Baixo()},
            {5, new Baixo()},
            {6, new Baixo()},
            {7, new Baixo()},
        };
    }
}