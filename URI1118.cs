using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1118
    {
        static void Uri1118(string[] args)
        {
            double A;
            double B;
            int X = 1;
            for (int i = X; i == X;)
            {
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

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                X = int.Parse(Console.ReadLine());
            }
        }
    }
}
