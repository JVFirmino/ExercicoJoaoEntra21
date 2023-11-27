using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoeVeiculo
{
    internal class MotoCorrida : Moto
    {
        public string Equipe { get; set; }
        public bool SuspensaoEsportiva { get; set; }
        public int NumeroCompeticao { get; set; }
        
        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"Equipe: {Equipe} Suspensão Esportiva:{SuspensaoEsportiva} Números da Competição:{NumeroCompeticao}");
        }
    }
}
