using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DevCSharp
{
    class URI1113
    {
        static void Uri1113(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);

            while (X != Y) 
            {
                if ( X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }   
        }
    }
}
