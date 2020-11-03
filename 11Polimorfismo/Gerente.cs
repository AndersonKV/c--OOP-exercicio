using System;

class Gerente : Imposto
{

    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("desconto gerente vale alimentação $" + (salario * 0.15));
    }

}