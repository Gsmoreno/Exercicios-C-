using System.Collections.Generic;
using McBanaldsMVC.Models;

namespace McBanaldsMVC.ViewModels
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}

        public PedidoViewModel()
        {
            this.Hamburgueres = new List<Hamburguer>();
        }
    }
}