using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Carro
    {
        public string placa;
        public string marca;
        public string modelo;
        public string cor;

        public string mensagem()
        {
            return $"Placa: {placa} Marca:{marca} Modelo:{modelo} Cor:{cor}";

        }
    }
}
