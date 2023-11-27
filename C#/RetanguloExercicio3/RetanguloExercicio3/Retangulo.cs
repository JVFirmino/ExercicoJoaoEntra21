using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetanguloExercicio3
{
    
    class Retangulo
    {
        private int altura;
        private int comprimento;

        public int Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (value > 0)
                {
                    altura = value;
                }
            }
        }
        public int Comprimento
        {
            get
            {
                return comprimento;
            }
            set
            {
                if (value > 0)
                {
                    comprimento = value;
                }
            }
        }

        public Retangulo(int altura, int comprimento)
        {
            Altura = altura;
            Comprimento = comprimento;
        }

        public void calculoPerimetro()
        {
            if (altura != 0 && comprimento != 0)
            {
                Console.WriteLine($"Perimetro: {(altura + comprimento) * 2}");
            }
            else
            {
                Console.WriteLine("Reveja os valores");
            }
        }
        public void calculoArea()
        {
            if (altura != 0 && comprimento != 0)
            {
                Console.WriteLine($"Área: {comprimento * altura}");
            }
            else
            {
                Console.WriteLine("Reveja os valores");
            }
        }
    }
    
}
