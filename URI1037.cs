using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1037
    {
        static void Uri1037(string[] args)
        {
            double N = double.Parse(Console.ReadLine());

            if (N >= 0.0 && N <= 25.0)
            {
                Console.WriteLine("Intervalo [0.0, 25.0]");
            }
            else if (N > 25.0 && N <= 50.0)
            {
                Console.WriteLine("Intervalo [25.0, 50.0]");
            }
            else if (N > 50.0 && N <= 75.0)
            {
                Console.WriteLine("Intervalo [50.0, 75.0]");
            }
            else if (N > 75.0 && N <= 100.0)
            {
                Console.WriteLine("Intervalo [75.0, 100.0]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
