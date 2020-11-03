using System;


class Pessoa
{
    //metodo 1
    public void apresentar()
    {
        Console.WriteLine("olar");
    }
    //metodo 2
    public void apresentar(string nome)
    {
        Console.WriteLine("olar " + nome);
    }

    //metodo 3
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("olar " + nome + " voce tem " + idade + " anos");
    }
}