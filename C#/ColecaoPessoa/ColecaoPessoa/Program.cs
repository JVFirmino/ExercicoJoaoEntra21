namespace ColecaoPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoas = new Pessoas();
            SortedList<string, Pessoas> SortPessoas = new SortedList<string, Pessoas>();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Adicionar Pessoas [1]Adicionar [2]Mostrar [3]Sair");
                int escolher = Convert.ToInt32(Console.ReadLine());

                switch (escolher)
                {
                    case 1:
                        pessoas.Adicionando(SortPessoas);
                        break;
                    case 2:
                        pessoas.Listando(SortPessoas);
                        break;
                    case 3:
                        continuar = false;
                        break;
                }
            }
            Console.WriteLine("Obrigado!!!");
        }
    }
}