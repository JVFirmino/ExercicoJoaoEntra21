using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroExercicio01
{ 
    class Carro
    {
        public string placa;
        public string marca;
        public string modelo;
        public string cor;

        public string display()
        {
            return $"Placa: {placa}, Marca: {marca}, Modelo: {modelo}, Cor: {cor}";
        }
    }
}
