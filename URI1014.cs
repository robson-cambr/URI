using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DevCSharp
{
    class URI1014
    {
        static void Uri1014(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            float Y = float.Parse(Console.ReadLine());
            float M = X / Y;

            Console.WriteLine($"{M:F3} km/l");
        }
    }
}
