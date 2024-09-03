/*-------------------------------------------------------------------
Questão 4: Somatório de Moedas
• Contextualização:No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total 
de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os, 
exibindo o total de moedas coletadas ao final.

@Lista: 01 - Lógica de Programação
@Autor: Lucas Azevedo Sampaio
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;


class Program 
{


      
      static void Main()
      {
        double r1, r2, r3, r4, r5, soma; 
        
         
         Console.WriteLine("Qual valor das moedas 1: ");
         double.TryParse (Console.ReadLine (), out r1);
       
         Console.WriteLine ("Qual valor das moedas 2");
         double.TryParse (Console.ReadLine (),out r2);

         Console.WriteLine ("Qual valor das moedas 3");
         double.TryParse (Console.ReadLine (),out r3);

         Console.WriteLine("Qual valor das moedas 4");
         double.TryParse (Console.ReadLine(), out r4);

         Console.WriteLine("Qual valor das moedas 5");
        double.TryParse (Console.ReadLine(), out r5);
        
        soma = r1 + r2 + r3 + r4 + r5;
         
         Console.WriteLine("Total de moedas é: " + soma);
         Console.ReadLine();
         

    
         

    
    



      }
}


      