using System.Reflection;

namespace MotoeVeiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotoCorrida motoCorrida = new MotoCorrida();

            motoCorrida.Modelo = "MotoCompeticao1";
            motoCorrida.Ano = 2023;
            motoCorrida.Cilindradas = 1000;
            motoCorrida.Equipe = "EquipeA";
            motoCorrida.SuspensaoEsportiva = true;
            motoCorrida.NumeroCompeticao = 42;

            MotoPasseio motoPasseio = new MotoPasseio();

            motoPasseio.Modelo = "MotoPasseio1";
            motoPasseio.Ano = 2022;
            motoPasseio.Cilindradas = 600;
            motoPasseio.PossuiBau = true;
            motoPasseio.TipoAssento = "Confortável";
            motoPasseio.FreiosCBS = true;

            Console.WriteLine("---------------------------------------------");
            motoCorrida.Exibir();
            Console.WriteLine("---------------------------------------------");
            motoPasseio.Exibir();
            Console.WriteLine("---------------------------------------------");
        }   
    }
}