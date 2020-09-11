using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1071
    {
        static void Uri1071(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int Min, Max, Total;

            if (X < Y)
            {
                Min = X;
                Max = Y;
            }
            else
            {
                Min = Y;
                Max = X;
                
            }
            Total = 0;
            for (int i=Min+1; i<Max; i++)
            {
                if (i % 2 != 0)
                {
                    Total += i;
                }
            }
            Console.WriteLine(Total);
        }
    }
}
