using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace curso.dominio
{   //a classe produto é uma subclasse de IComparable
    class Produto : IComparable
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }


        public Produto(int codigo, string descricao, double preco)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public override string ToString()
        {
            return Codigo
                + ", "
                + Descricao
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        //metodo para ordenar listagem dos produtos
        public int CompareTo(object obj)
        {
            //feito o casting para o tipo produto
            Produto outro = (Produto)obj;
            //se o resultado for zero, são iguais. Caso negativo o da esquerda é maior, caso positivo o da direita
            int resultado = Descricao.CompareTo(outro.Descricao);
            if(resultado != 0)
            {
                return resultado;
            }
            else
            {
                //caso os produtos sejam iguais, precisam ser ordenados por preco em ordem decrescente
                return -Preco.CompareTo(outro.Preco);
            }
        }
    }
}
