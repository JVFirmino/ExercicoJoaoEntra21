namespace Calculadora2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.x = 100;
            calculadora.y = 20;
            calculadora.Adicao();
            calculadora.Subtracao();
            calculadora.Multiplicacao();
            calculadora.Divisao();
            Console.ReadKey();
        }
    }
}