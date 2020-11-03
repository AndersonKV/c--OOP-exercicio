using System;

class PessoaJuridica : Padrao
{

    // regra de negocio vai fica em outra class
    //metodo obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("taxa de emprestimo para pessoa juridica R$" + (valor * 0.2));
    }


}