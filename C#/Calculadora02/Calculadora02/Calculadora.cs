using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora02
{
    internal class Calculadora
    {
        private int n1;
        private int n2;

        public int N1
        {
            get
            {
                return n1;
            }
            set
            {
                if (value > 0)
                {
                    n1 = value;
                }
            }
        }
        public int N2
        {
            get
            {
                return n2;
            }
            set
            {
                if (value > 0)
                {
                    n2 = value;
                }
            }
        }

        public Calculadora(int n1, int n2)
        {
            N1 = n1;
            N2 = n2;
        }

        public void Adicao()
        {
            if (n1 == 0 || n2 == 0)
            {
                Console.WriteLine("Inválido coloque acima de 0");
            }
            else
            {
                Console.WriteLine($"Adição: { n1 + n2}");
            }
        }
        public void Subtracao()
        {
            if (n1 == 0 || n2 == 0)
            {
                Console.WriteLine("Inválido coloque acima de 0");
            }
            else
            {
                Console.WriteLine($"Subtração: { n1 - n2}");
            }
        }
        public void Multiplicacao()
        {
            if (n1 == 0 || n2 == 0)
            {
                Console.WriteLine("Inválido coloque acima de 0");
            }
            else
            {
                Console.WriteLine($"Multiplicação: { n1* n2}");
            }
        }
        public void Divisao()
        {
            if (n1 == 0 || n2 == 0)
            {
                Console.WriteLine("Inválido coloque acima de 0");
            }
            else
            {
                Console.WriteLine($"Divisão: {n1 / n2}");
            }
        }
    }
}
