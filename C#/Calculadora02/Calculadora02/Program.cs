namespace Calculadora02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora(3, 3);

            calculadora.Adicao();
            calculadora.Subtracao();
            calculadora.Multiplicacao();
            calculadora.Divisao();
            Console.ReadKey();
        }
    }
}