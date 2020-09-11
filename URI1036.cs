using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DevCSharp
{
    class URI1036
    {
        static void Uri1036(string[] args)
        {
            double A, B, C;
            double R1, R2, Delta;
            string[] N;

            N = Console.ReadLine().Split(' ');
            A = Convert.ToDouble(N[0]);
            B = Convert.ToDouble(N[1]);
            C = Convert.ToDouble(N[2]);

            Delta = ((B*B) - (4*A*C));

            if ((Delta < 0) ||  (A == 0))
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else
            {
                R1 = ((-B + Math.Sqrt(Delta)) / (2*A));
                R2 = ((-B - Math.Sqrt(Delta)) / (2*A));

                Console.WriteLine("R1 = " + R1.ToString("F5"));
                Console.WriteLine("R2 = " + R2.ToString("F5"));
            }
        }
    }
}
