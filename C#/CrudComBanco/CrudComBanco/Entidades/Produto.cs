using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudComBanco.Entidades
{
    internal class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public double ValorUnitário { get; set; }

        public int qtdEstoque { get; set; }

        public Categoria Id_categoria { get; set; }
        public Produto()
        {

        }
        public Produto(int id, string nome, double valorUnitario, int estoque, Categoria id_categoria)
        {
            Id = id;
            Nome = nome;
            ValorUnitário = valorUnitario;
            qtdEstoque = estoque;
            Id_categoria = id_categoria;

        }
 
    }
}
