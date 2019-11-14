using System.Collections.Generic;
using System.IO;
using McBanaldsMVC.Models;

namespace McBanaldsMVC.Repositories
{
    public class HamburguerRepository
    {
        private const string PATH = "Database/Hamburguer.csv";

        
        public List<Hamburguer> ObterTodos()
        {
            List<Hamburguer> hamburguers = new List<Hamburguer>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Hamburguer h = new Hamburguer();
                string[] dados = linha.Split(";");
                h.Nome = dados[0];
                h.Preco = double.Parse(dados[1]);
                hamburguers.Add(h);
            }
                return hamburguers;
        }
    }
}