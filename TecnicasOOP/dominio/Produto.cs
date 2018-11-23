using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace curso.dominio
{
    class Produto
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
    }
}
