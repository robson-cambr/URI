using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1072
    {
        static void Uri1072(string[] args)
        {
            int A, N;
            int In = 0, Out = 0;

            A = int.Parse(Console.ReadLine());

            for (int i=0; i<A; i++)
            {
                N = int.Parse(Console.ReadLine());
                if (N >= 10 && N <= 20)
                {
                    In++;
                }
                else
                {
                    Out++;
                }
            }

            Console.WriteLine(In + " in");
            Console.WriteLine(Out + " out");
        }
    }
}
