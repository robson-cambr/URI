using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1073
    {
        static void Uri1073(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int Q;

            for (int i = 2; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Q = (int) Math.Pow(i, 2);
                    Console.WriteLine(i + "^2 = " + Q);
                }
            }
        }
    }
}
