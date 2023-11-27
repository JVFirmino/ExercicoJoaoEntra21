using CrudComBanco.Dao;
using CrudComBanco.Entidades;
using CrudComBanco.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudComBanco.Mostrar
{
    class MostrarProduto : Imostrar
    {
        public void Selecioando()
        {
            CrudBanco crudBanco = new CrudBanco();

            List<Produto> Selecionandoo = new List<Produto>();
            Console.WriteLine("Qual Id Produto:");
            int id_categoria = Convert.ToInt32(Console.ReadLine());

            crudBanco.Smostrando(id_categoria, Selecionandoo);

            foreach(Produto item in Selecionandoo)
            {
                Console.WriteLine($"ID: {item.Id}  Nome: {item.Nome.Trim()} Valor Unitário {item.ValorUnitário}  Qtd em Estoque {item.qtdEstoque}  Id da Categoria {item.Id_categoria.Id}");
            }
        }
    }
}
