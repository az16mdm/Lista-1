using System;
using System.Diagnostics;
class Program
{
    static void Main()

    {   
        Console.Clear();
        double vv, temp, multC, multV,total;

        Console.Write("Qual a velocidade do veiculo? ");
        double.TryParse(Console.ReadLine(), out vv);
        Console.Clear();

        Console.Write("Qual o tempo de viagem? ");
        double.TryParse(Console.ReadLine(), out temp);
        Console.Clear();

        Console.Write("Dê uma nota para o clima(quanto mais chovoso menor)? ");
        double.TryParse(Console.ReadLine(), out multC);
        Console.Clear();

        Console.Write("Dê uma nota para o estado do veiculo? ");
        double.TryParse(Console.ReadLine(), out multV);
        Console.Clear();

        total = (((vv * temp) * multC) * multV);

        Console.WriteLine("A distancia total foi: " + total);

        Console.WriteLine("\nPressione ENTER para fechar.");
        Console.ReadLine();
    }
}