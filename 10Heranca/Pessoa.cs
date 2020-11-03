using System;

class Pessoa
{
    protected string nome;
    protected int idade;

    protected void msgPessoa()
    {
        Console.WriteLine("nome " + nome + ", idade   " + idade);
    }
}