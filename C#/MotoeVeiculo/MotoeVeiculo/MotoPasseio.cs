using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoeVeiculo
{
    internal class MotoPasseio : Moto
    {
        public bool PossuiBau { get; set; }
        public string TipoAssento { get; set; }
        public bool FreiosCBS { get; set; }

        public override void Exibir() {
            base.Exibir();
            Console.WriteLine($"Possui Baú: {PossuiBau} Tipo Assento:{TipoAssento} Freios:{FreiosCBS}");
        }
    }
}
