namespace CarroExercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("4343-123A", "Fiat", "Uno Bolinha", "Preto");
            Console.WriteLine(carro.mostrarCarro());
            Console.ReadKey();
        }
    }
}