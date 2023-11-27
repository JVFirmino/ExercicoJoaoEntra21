namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(1, "Chocolate", 10, 5);

            produto.MostrarProduto();

            Console.ReadKey();
        }
    }
}