using System;

class Aluno
{

    //atributos
    public string nome;

    public double nota1, nota2;

    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    public void messagem()
    {
        double obterMedia = media();

        string obterSituacao = situacao(obterMedia);

        Console.WriteLine(nome + " esta " + obterSituacao + " com media " + obterMedia);
    }
}