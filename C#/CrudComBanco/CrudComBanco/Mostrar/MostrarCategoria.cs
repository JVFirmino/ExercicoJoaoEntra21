using CrudComBanco.Dao;
using CrudComBanco.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudComBanco.Mostrar
{
    internal class MostrarCategoria : Imostrar
    {
        public void Selecioando()
        {
            CrudBanco crudBanco = new CrudBanco();
            List<Categoria> lista = new List<Categoria>();  
            Console.WriteLine("Qual Id Categoria:");
            int id = Convert.ToInt32(Console.ReadLine());

            crudBanco.Smostrandoo(id, lista);

            foreach(Categoria item in lista)
            {
                Console.WriteLine($"ID: {item.Id}  Nome: {item.Nome}");
            }

        }
    }
}
