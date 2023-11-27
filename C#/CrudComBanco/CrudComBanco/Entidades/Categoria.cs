using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CrudComBanco
{
    internal class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Categoria() { }
        public Categoria(int id)
        {
            this.Id = id;
        }

        public Categoria(int id, string nome)
        {

            this.Id = id;
            this.Nome = nome;

        }


        
    }
}