using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DevCSharp
{
    class URI1117
    {
        static void Uri1117(string[] args)
        {
            double A;
            double B;

            A = double.Parse(Console.ReadLine());
            while (A < 0.0 || A > 10.0)
            {

                Console.WriteLine("nota invalida");
                A = double.Parse(Console.ReadLine());

            }

            B = double.Parse(Console.ReadLine());
            while (B < 0.0 || B > 10.0)
            {

                Console.WriteLine("nota invalida");
                B = double.Parse(Console.ReadLine());

            }

            double Media = (A + B) / 2;
            Console.WriteLine("Media = " + Media.ToString("F2"));

        }
    }
}
