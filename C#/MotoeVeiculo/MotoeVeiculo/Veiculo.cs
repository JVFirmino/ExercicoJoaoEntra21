using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoeVeiculo
{
    internal class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public virtual void Exibir () {

            Console.WriteLine($"Modelo:{Modelo} Ano:{Ano}");
        }
    }

}
