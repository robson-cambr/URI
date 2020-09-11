using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1078
    {
        static void Uri1078(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int R = i * N;
                Console.WriteLine(i + " x " + N + " = " + R);
            }
        }
    }
}
