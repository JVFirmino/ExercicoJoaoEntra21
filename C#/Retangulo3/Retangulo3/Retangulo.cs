using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo3
{
    internal class Retangulo
    {
        public double comprimento;
        public double altura;

        public string MostrarPerimetro()
        {
            return $"Perímetro: {comprimento * 2 + altura * 2}";
        }
        public string MostrarArea()
        {
            return $"Área: {comprimento * altura}";
        }
    }
}
