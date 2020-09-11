using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1068
    {
        static void Uri1068(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            for (int i = X; i < X + 12; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
