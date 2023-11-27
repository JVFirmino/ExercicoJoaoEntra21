using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoeVeiculo
{
    internal class Moto : Veiculo
    {
        public int Cilindradas;

        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"Cilindradas: {Cilindradas}");
        }
    }
}
