using System.Runtime;
using CrudComBanco.Crud;
using CrudComBanco.Entidades;
using CrudComBanco.Mostrar;

namespace CrudComBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Categoria categoria = new Categoria();
            List<Categoria> listar = new List<Categoria>();

            CrudProduto crudProduto = new CrudProduto();    

            CrudCategoria crudCategoria = new CrudCategoria();  

            List<Produto> listarr = new List<Produto>();

            MostrarProduto mostrarProduto = new MostrarProduto();

            MostrarCategoria mostrarCategoria = new MostrarCategoria();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Deseja adicionar Produto[1] ou Categoria[2] ou Sair[3]");
                int escolhapc = Convert.ToInt32(Console.ReadLine());
                if (escolhapc == 3) 
                { 
                    continuar = false;
                }
                while (escolhapc != 1 && escolhapc != 2)
                {
                    Console.WriteLine("Deseja adicionar Produto[1] ou Categoria[2]");
                    escolhapc = Convert.ToInt32(Console.ReadLine());
                }
                switch (escolhapc)
                {
                    case 1:
                        Console.WriteLine("Deseja [1]Mostrar [2]Adicionar [3]Remover [4]Alterar [5]Selecionar [6]Sair");
                        int escolhap = Convert.ToInt32(Console.ReadLine());
                        if (escolhap == 6)
                        {
                            continuar = false;
                            break;
                        }                        
                        switch (escolhap)
                        {
                            case 1:
                                crudProduto.CriandoLista(listarr);
                                
                            break;

                            case 2:
                                crudProduto.Adicionando();
                                
                            break;

                            case 3:
                                crudProduto.Removendo();
                                
                            break;

                            case 4:
                                crudProduto.Alterando();
                                
                            break;

                            case 5:
                                mostrarProduto.Selecioando();
                            break;
                        }
                    break;

                    case 2:
                        Console.WriteLine("Deseja [1]Mostrar [2]Adicionar [3]Remover [4]Alterar [5]Selecionar [6]Sair");
                        int escolhac = Convert.ToInt32(Console.ReadLine());
                        if (escolhac == 6)
                        {
                            continuar = false;
                            break;
                        }
                        switch (escolhac)
                        {
                            case 1:
                                crudCategoria.CriandoLista(listar);
                                
                            break;

                            case 2:
                                crudCategoria.Adicionando();
                                
                            break;

                            case 3:
                                crudCategoria.Removendo();
                                
                            break;

                            case 4:
                                crudCategoria.Alterando();
                                
                            break;

                            case 5:
                                mostrarCategoria.Selecioando();
                            break;
                        }
                    break;

                }
            }
            if(continuar == false)
            {
                Console.WriteLine("Obrigado por Acessar nosso Sistema S2");  
            }
        }
        
    }
}