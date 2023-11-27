using CrudComBanco.Dao;
using CrudComBanco.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudComBanco.Crud
{
    class CrudCategoria : Icrud <Categoria>
    {
        CrudBanco crudBanco = new CrudBanco();
        public void Adicionando()
        {
            Console.WriteLine("Informe o ID");
            int icategoria = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a Categoria");
            string ncategoria = Console.ReadLine();
            Categoria categoria = new Categoria(icategoria, ncategoria);

            crudBanco.Salvarr(categoria);
        }

        public void CriandoLista(List<Categoria> listar)
        {
            CrudBanco crudBanco = new CrudBanco();
            crudBanco.Listando(listar);
            foreach (Categoria item in listar)
            {
                Console.WriteLine($"ID: {item.Id}  Nome: {item.Nome}");

            }
        }
        public void Removendo()
        {
            Console.WriteLine("ID categoria");
            int id = Convert.ToInt32(Console.ReadLine());

            crudBanco.Removerr(id);
        }

        public void Alterando()
        {

            Console.WriteLine("Digite o ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Nome:");
            string nome = Console.ReadLine();

            crudBanco.Alterarr(id, nome);
        }


        
    }
}
