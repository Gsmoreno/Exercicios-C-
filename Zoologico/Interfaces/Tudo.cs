using System.Collections.Generic;
using Zoologico.Interfaces.Presos;

namespace Zoologico.Interfaces
{
    public class Tudo
    {
        public static Dictionary<int, Gaiolas> Presos = new Dictionary<int, Gaiolas>(){
            {1, new Pasto()},
            {2, new Gaiola()},
            {3, new CasaArvore()},
            {4, new CavernaPedra()},
            {5, new PiscinaGelada()},
            {6, new Piscina()},
            {7, new Aquario()}
            
        };
    }
}