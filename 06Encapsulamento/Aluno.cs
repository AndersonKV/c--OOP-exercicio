using System;


class Aluno
{
    private double nota1, nota2;

    private double media()
    {
        return (nota1 + nota2) / 2;

    }

    public void msg()
    {
        Console.WriteLine("informe sua primeira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("informe sua segunda nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("a media é " + media());

    }
}

