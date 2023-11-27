using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecaoPessoa
{
    internal class Pessoas
    {
        public string Pessoa { get; set; }

        public Pessoas() { }

        public Pessoas(string pessoa)
        {
            this.Pessoa = pessoa;
        }
        public void Adicionando(SortedList<string, Pessoas> SortPessoas)
        {
            Console.WriteLine("Id Pessoa");
            string id = Console.ReadLine();
            Console.WriteLine("Nome Pessoa");
            string nome = Console.ReadLine();

            Pessoas pessoa = new Pessoas();
            pessoa.Pessoa = nome;
            SortPessoas.Add(id, pessoa);

        }
        public void Listando(SortedList<string, Pessoas> SortPessoas)
        {
            foreach (KeyValuePair<string, Pessoas> kvp in SortPessoas)
            {
                Console.WriteLine($"Key: {kvp.Key}  Values: {kvp.Value.Pessoa}");
            }
        }
    }
}
