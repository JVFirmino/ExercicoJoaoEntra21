using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CrudProduto
{
    internal class Produtos
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set;}
        public double ValorUnitario { get; set;}

        public Produtos()
        {

        }

        public Produtos(int codigo, string descricao, int estoque, double valorUnitario) 
        { 
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Estoque = estoque;
            this.ValorUnitario = valorUnitario;
      
        }

        public void Adicionar(List<Produtos> produtos)
        {
           

            Console.WriteLine("Código Produto");
            int codigo = Convert.ToInt32(Console.ReadLine());

            foreach (var item in produtos)
            {
               while (codigo == item.Codigo)
               {
                    Console.WriteLine("Código Produto");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Descrição Produto");
            string descricao = Console.ReadLine();

            Console.WriteLine("Estoque do Produto");
            int estoque = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor Unitário do Produto");
            double valorUnitario = Convert.ToDouble(Console.ReadLine());

            Produtos produtoss = new Produtos(codigo, descricao, estoque, valorUnitario);

            produtos.Add(produtoss);  

        } 
        public void listando(List<Produtos> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Descrição: {item.Descricao}");
                Console.WriteLine($"Estoque: {item.Estoque}");
                Console.WriteLine($"Valor Unitário: {item.ValorUnitario}");
                Console.WriteLine("-----------------------------------------------");
            }
        }

        public void remover(List<Produtos> produtos)
        {
            bool removido = true;
            Produtos itens = null;
            Console.WriteLine("Código Produto");
            int rcodigo = Convert.ToInt32(Console.ReadLine());

            foreach (Produtos item in produtos)
            {
                if (rcodigo == item.Codigo)
                {
                    itens = item;
                    removido = false;
                }
            }
            if(removido == false)
            {
                produtos.Remove(itens);
            }
        }

        public void alterar(List<Produtos> produtos)
        {
            Console.WriteLine("Código Produto");
            int acodigo = Convert.ToInt32(Console.ReadLine());
            foreach (var item in produtos)
            {
                if(acodigo == item.Codigo)
                {
                    Console.WriteLine("Código Produto");
                    int codigoa = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Descrição Produto");
                    string adescricao = Console.ReadLine();

                    Console.WriteLine("Estoque do Produto");
                    int aestoque = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Valor Unitário do Produto");
                    double avalorUnitario = Convert.ToDouble(Console.ReadLine());

                    item.Codigo = codigoa;
                    item.Descricao = adescricao;
                    item.Estoque = aestoque;
                    item.ValorUnitario = avalorUnitario;
                    break;
                }        
            }
        }
    }
}
