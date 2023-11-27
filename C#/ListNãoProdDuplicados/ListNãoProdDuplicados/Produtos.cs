using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNãoProdDuplicados
{
    internal class Produtos
    {
        public string Nome { get; set; }
        public Produtos() { }
        public Produtos(string nome)
        {
            this.Nome = nome;
        }

        public void Adicionando(List<Produtos> Lista)
        {
            Console.WriteLine("Digite o nome do Produto: ");
            string nome = Console.ReadLine();
            foreach (var item in Lista)
            {
                while (nome == item.Nome)
                {
                    Console.WriteLine("Digite o nome do Produto: ");
                    nome = Console.ReadLine();
                }
            }

            Produtos produtos = new Produtos();
            produtos.Nome = nome;

            Lista.Add(produtos);
        }
        public void Listando(List<Produtos> Lista)
        {
            foreach (var item in Lista)
            {
                Console.WriteLine($"{item.Nome}");
            }
        }
    }
}
