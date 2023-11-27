namespace CalculadoraExercio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.x = 100;
            calculadora.y = 20;
            calculadora.adicao();
            calculadora.adicao();
            calculadora.multiplicacao();
            calculadora.divisao();
            Console.ReadKey();
        }
    }
}