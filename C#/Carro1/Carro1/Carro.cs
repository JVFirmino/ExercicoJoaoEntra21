using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro1
{
    internal class Carro
    {
        public string placa;
        public string marca;
        public string modelo;
        public string cor;

        public void mensagem()
        {
            Console.WriteLine($"Placa: {placa} Marca:{marca} Modelo:{modelo} Cor:{cor}");

        }
    }
}
