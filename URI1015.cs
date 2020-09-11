using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1015
    {
        static void Uri1015(string[] args)
        {
            string[] vet1 = Console.ReadLine().Split(' ');
            double x1 = Convert.ToDouble(vet1[0]);
            double y1 = Convert.ToDouble(vet1[1]);

            string[] vet2 = Console.ReadLine().Split(' ');
            double x2 = Convert.ToDouble(vet2[0]);
            double y2 = Convert.ToDouble(vet2[1]);

            double D = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 -y1, 2.0));

            Console.WriteLine(D.ToString("F4"));
        }
    }
}
