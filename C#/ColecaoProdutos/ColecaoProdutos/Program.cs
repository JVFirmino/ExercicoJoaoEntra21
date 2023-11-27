namespace ColecaoProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Produto produto1 = new Produto("Pão");
            produtos.Add(produto1);

            Produto produto2 = new Produto("Aveia");
            produtos.Add(produto2);

            SortedList<string, List<Produto>> categoriaProduto = new SortedList<string, List<Produto>>();
            categoriaProduto.Add("Cereais", produtos);

            foreach (KeyValuePair<string, List<Produto>> kvg in categoriaProduto)
            {
                foreach (Produto produto in kvg.Value)
                {
                    Console.WriteLine($"{kvg.Key} : {produto.Nome}");
                }
            }
        }
    }
}