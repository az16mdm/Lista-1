using System;
using System.Numerics;

class Program
{
    static void Main()
    {

        double ptsa, tpi, tpi2, tpdr1, tpdr2, cnv, total;

        Console.Write("qual a quantidade de xp acumulado?: ");
        double.TryParse(Console.ReadLine(), out ptsa);


        Console.Write("qual o XP concedido pelo primeiro tipo de inimigo?: ");
        double.TryParse(Console.ReadLine(), out tpi);

        Console.Write("quantos inimigos foram derrotados primeiro?: ");
        double.TryParse(Console.ReadLine(), out tpi2);

        Console.Write("qual o xp concedido pelo segundo tipo de inimigo?: ");
        double.TryParse(Console.ReadLine(), out tpdr1);

        Console.Write("qual o número de cada tipo de inimigo derrotado 2?: ");
        double.TryParse(Console.ReadLine(), out tpdr2);


        Console.Write("qual a constante de nivel?: ");
        double.TryParse(Console.ReadLine(), out cnv);

        tpi = tpi * tpi2;
        tpdr1 = tpdr1 * tpdr2;
        ptsa = tpi + tpi2 + ptsa;
        total = ptsa/cnv;

        Console.WriteLine("o xp total é de: " + Math.Floor(ptsa));
        Console.WriteLine("o nível é de: " + Math.Floor(total));

        Console.WriteLine("APERTE ENTER PARA SAIR");
        Console.ReadLine();
    }
}
