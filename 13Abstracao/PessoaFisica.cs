using System;

class PessoaFisica : Padrao
{


    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("taxa de emprestimo para pessoa fisica R$" + (valor * 0.01));
    }


}