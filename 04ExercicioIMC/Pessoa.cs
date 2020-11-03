using System;


class Pessoa
{

    public double peso, altura;

    public double calcule()
    {
        return peso / (altura + altura);
    }

    // public string belowdoTheNormal()
    // {

    // }
    // public string sizeNormal()
    // {

    // }
    // public string overweight()
    // {

    // }
    // public string obesityType1()
    // {

    // }
    // public string obesityType2()
    // {

    // }
    // public string obesityType3()
    // {

    // }

    public string result(double imc)
    {
        string response;

        if (imc < 17)
        { response = "\nMuito abaixo do peso"; }

        else if (imc > 17 & imc < 18.49)
        {
            response = "\n\nAbaixo do peso Ideal";
        }

        else if (imc > 18.5 & imc < 24.99)
        { response = "\n\nPeso Ideal"; }

        else if (imc > 25 & imc < 29.99)
        { response = "\n\nAcima do peso Ideal"; }

        else if (imc > 30 & imc < 34.49)
        { response = "\n\nObesidade"; }

        else if (imc > 35 & imc < 39.99)
        { response = "\n\nObesidade Severa"; }

        else if (imc > 40)
        { response = "\n\nObesidade Mórbida"; }

        else
        { response = "\n\nNão Reconhecido"; }

        return response;

    }

    public void message()
    {

        double getCalcule = calcule();
        string getResult = result(getCalcule);

        Console.WriteLine(getCalcule);
        Console.WriteLine(getResult);

    }
}
