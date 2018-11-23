using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso.dominio;
using System.Globalization;

namespace curso
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double PorcentagemDesconto { get; set; }
        //associacao com Produto
        public Produto produto { get; set; }
        //associacao com Pedido
        public Pedido pedido { get; set; }

        public ItemPedido (int quantidade, double PorcentagemDesconto, Pedido pedido, Produto produto)
        {
            this.Quantidade = quantidade;
            this.PorcentagemDesconto = PorcentagemDesconto;
            this.pedido = pedido;
            this.produto = produto;
        }

        public double subTotal()
        {
            double desconto = produto.Preco * PorcentagemDesconto / 100.00;
            return (produto.Preco - desconto) * Quantidade;
        }

        public override string ToString()
        {
            return produto.Descricao
                + ", Preço"
                + produto.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Quantidade
                + ", Desconto: "
                + PorcentagemDesconto.ToString("F2", CultureInfo.InvariantCulture)
                + "%, Subtotal: "
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
