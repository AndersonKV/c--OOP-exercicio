using System;

class Imposto
{
    //este metodo vai sofrer possiveis modificações - virtual
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("desconto do vale alimentação $" + (salario * 0.1));
    }

    public virtual void valeTransporte(double salario)
    {
        Console.WriteLine("desconto do vale transporte $" + (salario * 0.6));

    }
}