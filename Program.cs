using System;

namespace Busca_nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]nomes= new string[10];

            for(var i=0; i<10;i++){
            Console.WriteLine("Digite um nome");
            nomes[i] = Console.ReadLine();
            
            if(nomes[i] == ""){
            Console.WriteLine("Digite algum nome");
            }

            }

            Console.ForegroundColor= ConsoleColor.Yellow;
            for(var i=0; i<10;i++){
            Console.WriteLine(nomes[i]);
            }
            
            Console.WriteLine("Busque um nome");
            string busca = Console.ReadLine();

            for(var i=0;i<10;i++){

            if(busca == nomes[i]){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ACHEI!."+nomes[i]);
            }
            
            }
           if(busca != nomes[0] && busca != nomes[1] && busca != nomes[2] && busca != nomes[3] && busca != nomes[4] && busca != nomes[5] && busca != nomes[6] && busca != nomes[7] && busca != nomes[8] && busca != nomes[9]){
               Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Não achei =( ");
           }
            
            
        }
                
    }
}         

    


