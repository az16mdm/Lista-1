/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
• Comando: Crie um programa que receba o

@Lista: 01 - Lógica de Programação
@Autor: Lucas Azevedo
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;


  class Program
{

    static void Main()
    {
        Console.WriteLine("Qual o nome do seu player?");
        string? nome = Console.ReadLine();


        Console.WriteLine("Qual a idade do seu player");
        int idade;
        int.TryParse(Console.ReadLine(), out idade);
        

      Console.WriteLine("Qual o nível do seu player?");
        int nível;
        int.TryParse(Console.ReadLine(), out nível);
        

        Console.WriteLine("Qual a raça do seu player?");
        string? raça = Console.ReadLine();

        Console.WriteLine("Qual classe do seu player?");
        string? classe = Console.ReadLine();

        Console.WriteLine("nome " + nome);
        Console.WriteLine("idade " + idade);
        Console.WriteLine("nível " + nível);
        Console.WriteLine("raça " + raça);
        Console.WriteLine("classe " + classe);




        
        
        
    }
    
 }


