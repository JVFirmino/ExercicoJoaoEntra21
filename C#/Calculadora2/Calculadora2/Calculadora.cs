using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    internal class Calculadora
    {
        public int x;
        public int y;

        public void Adicao()
        {
            Console.WriteLine($"Adição: {x + y}");
        }
        public void Subtracao()
        {
            Console.WriteLine($"Subtração: {x - y}");
        }
        public void Multiplicacao()
        {
            Console.WriteLine($"Multiplicação: {x * y}");
        }
        public void Divisao()
        {
            Console.WriteLine($"Divisão: {x / y}");
        }
    }
}
