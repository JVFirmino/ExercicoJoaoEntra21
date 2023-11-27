namespace ProdutoExercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();    
            produto.codigo = 1;
            produto.descricao = "Chocolate";
            produto.ValorUnitario = 20;
            produto.mostrar();
            Console.ReadKey();

        }
    }
}