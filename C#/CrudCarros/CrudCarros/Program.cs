namespace CrudCarros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            List<Carro> listar = new List<Carro>();
            bool continuar = true;
            while(continuar)
            {

                Console.WriteLine("1 - Mostra  2- Adicionar  3- Remover  4- Alterar  5- Sair");
                int escolher = Convert.ToInt32(Console.ReadLine());

                switch (escolher) 
                {
                    case 1:
                        carro.Listar(listar);
                    break;

                    case 2:
                        carro.Adicioando(listar);
                    break;

                    case 3:
                        carro.Remover(listar);
                    break;

                    case 4:
                        carro.Alterar(listar);
                    break;

                    case 5:
                        continuar = false;
                    break;
                }
            }
        }
    }
}