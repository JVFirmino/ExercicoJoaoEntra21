using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Produto
    {
        private int codigo;
        private string descricao;
        private int estoque;
        private double valorUnitario;
        private double valorDesconto;
        private double valorTaxa;
        private double valorTotal;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                if (value > 0)
                {
                    codigo = value;
                }
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                if (value.Length >= 4)
                {
                    descricao = value;
                }
                else
                {
                    descricao = "Valor Inválido";
                }
            }
        }
        public int Estoque
        {
            get
            {
                return estoque;
            }
            set
            {
                if (value > 0)
                {
                    estoque = value;
                }
            }
        }
        public double ValorUnitário
        {
            get
            {
                return valorUnitario;
            }
            set
            {
                if (value > 0)
                {
                    valorUnitario = value;
                }
            }
        }

        public Produto(int codigo, string descricao, int estoque, double valorUnitario)
        {
            Codigo = codigo;
            Descricao = descricao;
            Estoque = estoque;
            ValorUnitário = valorUnitario;
        }

        public void MostrarProduto()
        {
            if (codigo == 0 || valorUnitario == 0 || estoque == 0)
            {
                Console.WriteLine("Reveja os valores");
            }
            else
            {
                valorDesconto = valorUnitario / 100 * 5;
                valorTaxa = valorUnitario / 100 * 10;
                valorTotal = valorUnitario + valorTaxa - valorDesconto;

                Console.WriteLine($"Código: {codigo} Descrição: {descricao} Estoque: {estoque}");
                Console.WriteLine($"Valor unitário: {valorUnitario} Valor desconto:{valorDesconto} Valor taxa: {valorTaxa} Valor total: {valorTotal}");
            }
        }
    }
}

