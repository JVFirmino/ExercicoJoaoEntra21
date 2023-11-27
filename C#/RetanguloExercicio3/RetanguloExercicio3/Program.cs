namespace RetanguloExercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(4, 6);

            retangulo.calculoArea();
            retangulo.calculoPerimetro();
            Console.ReadKey();        
        }
    }
}