using System;

class Colaborador : Pessoa
{
    private double salario;

    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        msgPessoa();
        msgColaborador();
    }
    private void msgColaborador()
    {
        Console.WriteLine("salario: " + salario);
    }
}