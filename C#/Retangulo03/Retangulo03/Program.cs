namespace Retangulo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(6, 8);

            retangulo.CalculoArea();
            retangulo.CalculoPerimetro();
            Console.ReadKey();
        }
    }
}