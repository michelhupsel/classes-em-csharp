using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for(int i = 0; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }
        }
    }
}
