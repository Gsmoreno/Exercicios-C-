using System.IO;
using McBanaldsMVC.Models;

namespace McBanaldsMVC.Repositories
{
    public class PedidoRepository
    {
        private const string PATH = "Database/Pedido.csv";

        public PedidoRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Pedido pedido)
        {
            var linha = new string[]{PrepararRegistroCSV(pedido)};
            File.AppendAllLines(PATH, linha);

            return true; 
        }

        private string PrepararRegistroCSV(Pedido pedido)
        {
            Cliente c = pedido.Cliente;
            Hamburguer h = pedido.Hamburguer;
            Shake s = pedido.Shake;

            return $"cliente_nome={c.Nome}; cliente_endereço={c.Endereco};cliente_telefone={c.Telefone};cliente_email={c.Email}; hambuerguer_nome={h.Nome}; hamburguer_preco={h.Preco}; shake_nome={s.Nome}; shake_preco={s.Preco}; data_pedido={pedido.DataDoPedido}; preco_total={pedido.PrecoTotal}";
        }
    }
}