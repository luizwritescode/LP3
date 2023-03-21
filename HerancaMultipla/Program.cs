
using System;
using System.Collections;

interface IJunior
{
    void Trampar();
}
class Junior : IJunior
{

    public void Trampar()
    {
        Console.WriteLine("Trampando como Junior...");
    }
}

interface ISenior
{
    void Trampar();
}

class Senior : ISenior
{

    public void Trampar()
    {

        Console.WriteLine("Trampando como Senior...");
    }
}


class Programador : IJunior, ISenior
{

    int dinheiro = 0;

    Senior senior = new Senior();
    Junior junior = new Junior();

    public void Trampar() { }

    public void TramparSenior()
    {
        senior.Trampar();

        dinheiro += 500;

        PrintDinheiro();
    }

    public void TramparJunior()
    {
        junior.Trampar();

        dinheiro += 100;

        PrintDinheiro();
    }

    public void PrintDinheiro()
    {
        Console.WriteLine("Dinheiro: " + this.dinheiro);
    }
}


class HerancaMultipla
{

    static char ReadInput()
    {
        Console.Write(">");
        return Console.ReadLine()[0];
    }

    static void Main()
    {

        Console.WriteLine("Exemplo Herança Multipla");
        Console.WriteLine("q\tsair");
        Console.WriteLine("s\ttrampar como programador senior");
        Console.WriteLine("j\ttrampar como programador junior");
        Console.WriteLine("");


        Programador p = new Programador();

        p.PrintDinheiro();
        Console.WriteLine();


        char INPUT = ReadInput();

        while (true)
        {

            if (INPUT == 's')
                p.TramparSenior();
            else if (INPUT == 'j')
                p.TramparJunior();
            else if (INPUT == 'q')
                Environment.Exit(1);

            INPUT = ReadInput();
        }

    }


}