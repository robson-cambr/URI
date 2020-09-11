using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DevCSharp
{
    class URI1002
    {
        static void Uri1002 (string[] args)
        {
 
            double N = 3.14159;
            double Raio;
           
            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double A = N * Math.Pow(Raio, 2.0);

            Console.WriteLine("A = " + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
