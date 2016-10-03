using System;
using tabuleiro;


namespace Principal 
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);
            Console.WriteLine("Posoção: " + P);
            Console.ReadLine(); 
        }
    }
}
