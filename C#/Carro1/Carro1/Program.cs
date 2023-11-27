namespace Carro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.placa = "4343-123A";
            carro.marca = "Fiat";
            carro.modelo = "Uno Bolinha";
            carro.cor = "Preto";
            carro.mensagem();
            Console.ReadKey();
        }
    }
}