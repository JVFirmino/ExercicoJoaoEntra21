using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCarros
{
    internal class Carro
    {
        public string Placa { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public Carro() { }
        public Carro(string placa, string marca, string modelo, string cor)
        {
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
        }
        public void Adicioando(List<Carro> listar)
        {
            Console.WriteLine("Placa do Carro");
            string placa = Console.ReadLine();

            foreach (var item in listar)
            {
                while(placa == item.Placa)
                {
                    Console.WriteLine("Placa do Carro");
                    placa = Console.ReadLine();

                }
            }

            Console.WriteLine("Marca do Carro");
            string marca = Console.ReadLine();

            Console.WriteLine("Modelo do Carro");
            string modelo = Console.ReadLine();

            Console.WriteLine("Cor do Carro");
            string cor = Console.ReadLine();

            Carro carro = new Carro(placa, marca, modelo, cor);

            listar.Add(carro);

        }

        public void Listar(List<Carro> listar)
        {
            foreach (var item in listar)
            {
                Console.WriteLine($"Placa: {item.Placa} Marca: {item.Marca} Modelo: {item.Modelo} Cor: {item.Cor}");
            }

        }

        public void Remover(List<Carro> listar)
        {
            Console.WriteLine("Placa do Carro");
            string placa = Console.ReadLine();
            Carro itens = null;
            foreach (var item in listar)
            {
                if (placa == item.Placa)
                {
                    itens = item;
                    break;
                }
            }
            listar.Remove(itens);
        }
        public void Alterar(List<Carro> listar)
        {
            Console.WriteLine("Placa do Carro");
            string placa = Console.ReadLine();
            foreach (var item in listar)
            {
                if (placa == item.Placa)
                {
                    Console.WriteLine("Placa do Carro");
                    string nplaca = Console.ReadLine();

                    Console.WriteLine("Marca do Carro");
                    string nmarca = Console.ReadLine();

                    Console.WriteLine("Modelo do Carro");
                    string nmodelo = Console.ReadLine();

                    Console.WriteLine("Cor do Carro");
                    string ncor = Console.ReadLine();

                    item.Placa = nplaca;
                    item.Marca = nmarca;
                    item.Modelo = nmodelo;
                    item.Cor = ncor;
                    break;
                }
            }
        }


        
    }

}

