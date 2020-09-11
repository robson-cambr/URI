using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1134
    {
        static void Uri1134(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int A = 0, G = 0, D = 0;

            while (N > 0 && N != 4)
            {
                if (N == 1)
                {
                    A += 1;
                }
                else if (N == 2)
                {
                    G += 1;
                }
                else if (N == 3)
                {
                    D += 1;
                }
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + A.ToString());
            Console.WriteLine("Gasolina: " + G.ToString());
            Console.WriteLine("Diesel: " + D.ToString());
        }
    }
}
