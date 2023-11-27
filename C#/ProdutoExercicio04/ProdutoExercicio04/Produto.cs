using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoExercicio04
{
    internal class Produto
    {
        public int codigo;
        public string descricao;
        public int estoque = 10;
        public double ValorUnitario;
        double valorDesconto;
        double valorTaxa;
        double valorTotal;
        public void mostrar()
        {
            valorDesconto = (ValorUnitario / 100) * 10;
            valorTaxa = (ValorUnitario / 100) * 20;
            valorTotal = ValorUnitario + valorTaxa - valorDesconto;
            Console.WriteLine($"Código: {codigo} Descrição: {descricao} Estoque: {estoque}");
            Console.WriteLine($"Valor Unitário: {ValorUnitario} Valor desconto: {valorDesconto} Valor taxa: {valorTaxa} Valor total: {valorTotal} ");
        }
    }
}
