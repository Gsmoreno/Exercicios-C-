using System;
using EscolaDeRock.interfaces;
using EscolaDeRock.Models;

namespace EscolaDeRock {
    class Program {
        static void Main (string[] args) {
            string[] itensMenuPrincipal = Enum.GetName(typeof(FormacaoEnum));
            string[] itensMenuPrincipal = Enum.GetName(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>(){
                "    - 0    ",
                "    - 1    "
            };
            int opcoesFormacaoSelecionada = 0;
            string menuBar = "=========================";

            do{
                bool formacaoEscolhida = false;
            }
            
            
        }
    }
}