namespace Retangulo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.altura = 5;
            retangulo.comprimento = 10;

            Console.WriteLine(retangulo.MostrarPerimetro());
            Console.WriteLine(retangulo.MostrarArea());

            Console.ReadKey();
        }
    }
}