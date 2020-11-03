using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.nome = "ralf";
            obj.idade = 30;
            obj.mensagem();
        }
    }
}
