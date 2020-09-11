using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1011
    {
        static void Uri1011(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double T = (4.0 / 3.0) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + T.ToString("F3"));
        }
    }
}
