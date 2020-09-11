using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1017
    {
        static void Uri1017(string[] args)
        {
            int Hour = int.Parse(Console.ReadLine());
            int Kmh = int.Parse(Console.ReadLine());
            double Distance = Hour * Kmh;
            double LiterG = Distance / 12;

            Console.WriteLine($"{LiterG:F3}");
        }
    }
}
