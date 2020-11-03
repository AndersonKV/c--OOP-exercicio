using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto objectEstagiario = new Estagiario();

            objectEstagiario.valeAlimentacao(1000);
            objectEstagiario.valeTransporte(1000);

            Console.WriteLine("===========");

            Imposto objectGerente = new Gerente();

            objectGerente.valeAlimentacao(5000);
            objectGerente.valeTransporte(5000);

            Console.WriteLine("===========");

            Imposto objectAtendente = new Atendente();
            objectAtendente.valeAlimentacao(2000);
            objectAtendente.valeTransporte(2000);
        }
    }
}
