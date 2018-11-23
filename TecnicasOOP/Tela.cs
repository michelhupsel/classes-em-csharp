using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using curso.dominio;

namespace curso
{
    class Tela
    {
        //Classe responsavel por conter operações que interagem com o usuario no modo console

        public static void MostrarMenu()
        {
            Console.WriteLine("1 - Listar produtos ordenadamente");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar pedido");
            Console.WriteLine("4 - Mostrar dados de um pedido");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Digite uma opcao:");
        }

        public static void MostrarProdutos()
        {
            Console.WriteLine("LISTAGEM DE PRODUTOS:");
            for (int i = 0; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }
        }

        public static void CadastrarProduto()
        {
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto p = new Produto(codigo, descricao, preco);
            Program.produtos.Add(p);
            Program.produtos.Sort();
        }

        public static void CadastrarPedido()
        {
            Console.WriteLine("Digite os dados do pedido:");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Pedido p = new Pedido(codigo, dia, mes, ano);

            Console.Write("Quantos itens tem o pedido? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os dados do " + (i + 1) + " item: ");
                Console.Write("Produto (código): ");
                int codProduto = int.Parse(Console.ReadLine());
                int posicao = Program.produtos.FindIndex(x => x.Codigo == codProduto);
                if(posicao == -1)
                {
                    throw new ModelException("Codigo de produto nao encontrado: " + codProduto);
                }
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                ItemPedido ip = new ItemPedido(quantidade, porcentagem, p, Program.produtos[posicao]);
                p.itens.Add(ip);
            }
            Program.pedidos.Add(p);
        }

        public static void MostrarPedido()
        {
            Console.Write("Digite o codigo do Pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int posicao = Program.pedidos.FindIndex(x => x.codigo == codPedido);
            if(posicao == -1)
            {
                throw new ModelException("Codigo de pedido nao encontrado: " + codPedido);
            }
            Console.WriteLine(Program.pedidos[posicao]);
            Console.WriteLine();
        }
    }
}
