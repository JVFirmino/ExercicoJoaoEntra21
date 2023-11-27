namespace Produto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Codigo = 1;
            produto.Descricao = "Chocolate";
            produto.ValorUnitario = 20;
            produto.Mostrar();
            Console.ReadKey();
        }
    }
}