using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();

            obj.altura = 1.75;
            obj.peso = 80;
            obj.message();
        }
    }
}
