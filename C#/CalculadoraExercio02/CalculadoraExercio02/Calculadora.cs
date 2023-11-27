using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraExercio02
{
    internal class Calculadora
    {
        public int x;
        public int y;

        public void adicao()
        {
            Console.WriteLine($"Adição: {x + y}");
        }
        public void subtracao()
        {
            Console.WriteLine($"Subtração: {x - y}");
        }
        public void multiplicacao()
        {
            Console.WriteLine($"Multiplicação: {x * y}");
        }
        public void divisao()
        {
            Console.WriteLine($"Divisão: {x / y}");
        }
    }
}
