using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;


class Program 
{


      
      static void Main()
      {
        double r1, r2, r3, r4, soma; 
        
         
         Console.WriteLine("Quantidade de moedas de ouro: ");
         double.TryParse (Console.ReadLine (), out r1);
       
         Console.WriteLine ("Taxa de Conversão: ");
         double.TryParse (Console.ReadLine (),out r2);

         Console.WriteLine ("Bônus de Evento:");
         double.TryParse (Console.ReadLine (),out r3);

         Console.WriteLine("Bônus de Habilidade:");
         double.TryParse (Console.ReadLine(), out r4);
        
        soma =((r1 / r2)* r3) *r4;
         
         Console.WriteLine("Cristais totais: " + Math.Floor(soma));
         Console.ReadLine();

         System.Console.WriteLine("APERTE ENTER PARA SAIR");
         Console.ReadLine();
        
         

    
         

    
    



      }
}
