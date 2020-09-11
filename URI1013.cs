using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DevCSharp
{
    class URI1013
    {
        static void Uri1013(string[] args)
        {
            int A, B, C, D;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = (A + B + Math.Abs (A - B)) / 2;
            D = (D + C + Math.Abs(D - C)) / 2;

            Console.WriteLine($"{D} eh o maior");
        }
    }
}
