using CrudComBanco.Entidades;
using CrudComBanco.Interface;
using CrudComBanco.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudComBanco.Crud
{
    class CrudProduto : Icrud<Produto>
    {
        CrudBanco crudBanco = new CrudBanco();

        public void Adicionando()
        {
            Console.WriteLine("Informe o ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o Valor Unitário do Produto");
            float valorUnitario = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade em estoque");
            int qtdEstoque = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ID da Categoria");
            int id_categoria = Convert.ToInt32(Console.ReadLine());
            Categoria categoria = new Categoria(id_categoria);

            Produto produto = new Produto(id, nome, valorUnitario, qtdEstoque, categoria);


            crudBanco.Salvar(produto);
        }

        public void CriandoLista(List<Produto> listarr)
        {
            crudBanco.Listando(listarr);
            foreach (Produto item in listarr)
            {
                Console.WriteLine($"ID: {item.Id}  Nome: {item.Nome.Trim()} Valor Unitário {item.ValorUnitário}  Qtd em Estoque {item.qtdEstoque}  Id da Categoria {item.Id_categoria.Id}");

            }
        }
        public void Removendo()
        {
            Console.WriteLine("ID Produto");
            int id = Convert.ToInt32(Console.ReadLine());

            crudBanco.Remover(id);
        }

        public void Alterando()
        {

            Console.WriteLine("Digite o ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o Valor Unitário do Produto");
            float valorUnitario = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade em estoque");
            int qtdEstoque = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ID da Categoria");
            int id_categoria = Convert.ToInt32(Console.ReadLine());
            Categoria categoria = new Categoria(id_categoria);

            crudBanco.Alterar(id, nome, valorUnitario, qtdEstoque, categoria);
        }

       
    }
}
