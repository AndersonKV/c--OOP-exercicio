using System;

namespace _14Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            //interface herda varias funcionalidades obrigatorias
            Calculo c = new Calculo();
            c.somar(10, 15);

            c.subtrair(50, 10);
        }
    }
}
