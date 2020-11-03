using System;

abstract class Padrao
{


    // regra de negocio vai fica em outra class
    //metodo obrigatorio 
    public abstract void taxaEmprestimo(double valor);

    public void calculoPolpanca(double valor, double taxa)
    {
        Console.WriteLine("ganhas obitidos pela poupança " + (valor * taxa));
    }
}