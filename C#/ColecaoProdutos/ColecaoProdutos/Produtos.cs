﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecaoProdutos
{
    internal class Produto
    {
        public string Nome { get; set; }

        public Produto(string nome)
        {
            this.Nome = nome;
        }
    }
}
