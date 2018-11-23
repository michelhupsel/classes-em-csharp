using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso.dominio;

namespace curso
{
    class Program
    {
        //lista estatica de produtos fica disponivel para todo o programa
        public static List<Produto> produtos = new List<Produto>();


        static void Main(string[] args)
        {

            int opcao = 0;

            produtos.Add(new Produto(1001, "Cadeira simples", 500.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofa de tres lugares", 2000.00));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));

            while(opcao != 5)
            {
                Console.Clear();
                //chama o metodo da classe tela
                Tela.MostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                
            }
      
            Console.Read();
        }
    }
}

