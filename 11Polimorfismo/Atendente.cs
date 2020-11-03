using System;

class Atendente : Imposto
{
    //polimorfismo
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("desconto atendente vale alimentação $" + (salario * 0.12));
    }

}