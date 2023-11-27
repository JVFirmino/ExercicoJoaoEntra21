using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroExercicio1
{
    internal class Carro
    {
     
        private string placa;
        public string Placa
        {
            get
            {
                return placa;
            }
            set
            {
                if (value.Length >= 4)
                {
                    placa = value;
                }
                else
                {
                    placa = "Valor Inválido";
                }
            }
        }

        private string marca;
        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                if (value.Length >= 4)
                {
                    marca = value;
                }
                else
                {
                    marca = "Valor Inválido";
                }
            }
        }

        private string modelo;
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                if (value.Length >= 4)
                {
                    modelo = value;
                }
                else
                {
                    modelo = "Valor Inválido";
                }
            }
        }

        private string cor;
        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                if (value.Length >= 4)
                {
                    cor = value;
                }
                else
                {
                    cor = "Valor Inválido";
                }
            }
        }

        public Carro(string placa, string marca, string modelo, string cor)
        {
            Placa = placa;
            Marca = marca; ;
            Modelo = modelo;
            Cor = cor;
        }

        public string mostrarCarro()
        {
            return $"Placa: {placa}, Marca: {marca}, Modelo: {modelo} Cor: {cor}";
        }
    }
}
