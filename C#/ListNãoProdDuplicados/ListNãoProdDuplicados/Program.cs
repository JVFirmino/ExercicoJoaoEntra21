namespace ListNãoProdDuplicados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produtos produtos = new Produtos();
            List<Produtos> lista = new List<Produtos>();
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Deseja continuar adicionando produto - Sim[S] / Não[N] ou Mostrar[M]");
                string escolha = Console.ReadLine().ToUpper();
                switch (escolha)
                {
                    case "S":
                        produtos.Adicionando(lista);
                        break;
                    case "N":
                        continuar = false;
                        break;
                    case "M":
                        produtos.Listando(lista);
                        break;
                    default:
                        Console.WriteLine("Digite N ou S");
                        break;
                }
            }
            Console.WriteLine("Obrigado!!!");
        }
    }
}