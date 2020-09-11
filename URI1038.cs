using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Schema;

namespace DevCSharp
{
    class URI1038
    {
        static void Uri1038(string[] args)
        {
            string[] C = Console.ReadLine().Split(' ');
            int N = Convert.ToInt32(C[0]);
            double A = Convert.ToDouble(C[1]);

            if (N == 1)
            {
                A *= 4.00;
                Console.WriteLine("Total R$: " + A.ToString("F2"));
            }

            else if (N == 2)
            {
                A *= 4.50;
                Console.WriteLine("Total R$: " + A.ToString("F2"));
            }
            else if (N == 3)
            {
                A *= 5.00;
                Console.WriteLine("Total R$: " + A.ToString("F2"));
            }
            else if (N == 4)
            {
                A *= 2.00;
                Console.WriteLine("Total R$: " + A.ToString("F2"));
            }
            else if (N == 5)
            {
                A *= 1.50;
                Console.WriteLine("Total R$: " + A.ToString("F2"));
            }            
        }
    }
}
