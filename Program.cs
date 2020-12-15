using System;

namespace Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
           int resposta;

            do{
            Console.Write("Digite uma nota entre 0 e 10: ");
            resposta = int.Parse(Console.ReadLine());

            if (resposta > 0 || resposta >= 10){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número inválido!");
                Console.ResetColor();
            }

            }while(resposta > 0 || resposta > 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Número válido!"); 
        }
    }
}
