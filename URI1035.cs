using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1035
    {
        static void Uri1035(string[] args)
        {
            int A, B, C, D;
            string[] N;

            N = Console.ReadLine().Split(' ');
            A = Convert.ToInt32(N[0]);
            B = Convert.ToInt32(N[1]);
            C = Convert.ToInt32(N[2]);
            D = Convert.ToInt32(N[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0 )
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }  
        }
    }
}
