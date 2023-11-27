using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto4
{
    internal class Produto
    {
        public int Codigo;
        public string Descricao;
        public int Estoque = 10;
        public double ValorUnitario;
        double valorDesconto;
        double valorTaxa;
        double valorTotal;
        public void Mostrar()
        {
            valorDesconto = (ValorUnitario / 100) * 10;
            valorTaxa = (ValorUnitario / 100) * 20;
            valorTotal = ValorUnitario + valorTaxa - valorDesconto;
            Console.WriteLine($"Código: {Codigo} Descrição: {Descricao} Estoque: {Estoque}");
            Console.WriteLine($"Valor Unitário: {ValorUnitario} Valor desconto: {valorDesconto} Valor taxa: {valorTaxa} Valor total: {valorTotal} ");
        }
    }
}
