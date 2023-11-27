using System.Collections.Generic;

namespace CrudProduto
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Produtos produtoss = new Produtos();
            List<Produtos> produtos = new List<Produtos>();   
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Escolha Ver Produtos[1]  Adicionar Produtos[2]  Remover Produtos[3]  Alterar Produto[4] [5]Sair");
                int escolher = Convert.ToInt32(Console.ReadLine());   

                switch (escolher)
                {
                    case 1:
                        produtoss.listando(produtos);
                        break;
                    case 2:
                        produtoss.Adicionar(produtos);           
                        break;
                    case 3:
                        produtoss.remover(produtos);
                        break;
                    case 4:
                        produtoss.alterar(produtos);
                        break;
                    case 5:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

            }
            Console.WriteLine("Obrigado!!!");

        }

    }
}