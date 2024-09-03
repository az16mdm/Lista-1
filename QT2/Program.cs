/*-------------------------------------------------------------------
Questão 2: Pontuação Final
• Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
base nos inimigos derrotados e pontos adicionais.
• Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
dificuldade), e então calcule e exiba a pontuação final.

@Lista: 01 - Lógica de Programação
@Autor: Lucas Azevedo
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System


  class Program
{

    static void Main()
    {
        Console.WriteLine("Quantidades de inimigos derrotados?");
        int inimigosd;
        int.TryParse(Console.ReadLine(), out inimigosd);


        Console.WriteLine("Quantidade de pontos por inimigo");
        int points;
        int.TryParse(Console.ReadLine(), out points);
        

      Console.WriteLine("Qual foi o Bônus da missâo?");
        int bonus;
        int.TryParse(Console.ReadLine(), out bonus);

        Console.WriteLine("Multiplicador por tipo de inimigo");
        int MultiInimigo;
        int.TryParse(Console.ReadLine(), out MultiInimigo);

        Console.WriteLine("Multiplicador por tipo de dificuldade");
        int MultiDificuldade;
        int.TryParse(Console.ReadLine(), out MultiDificuldade);

        double pontost = (((inimigosd * points) + MultiInimigo) * MultiDificuldade)+ bonus;
        Console.WriteLine("sua pontuação foi de" + pontost);

        Console.WriteLine("PRECIONE ENTER PARA SAIR");
        Console.WriteLine("");
    }

        

     


        
        
        
    }
    
 

    