using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1010
    {
        static void Uri1010(string[] args)
        {
            int Product0;
            int Amount0;
            double Price0;
            string[] Sale0;

            Sale0 = Console.ReadLine().Split(' ');
            Product0 = Convert.ToInt32(Sale0[0]);
            Amount0 = Convert.ToInt32(Sale0[1]);
            Price0 = Convert.ToDouble(Sale0[2]);

            int Product1;
            int Amount1;
            double Price1;
            string[] Sale1;

            Sale1 = Console.ReadLine().Split(' ');
            Product1 = Convert.ToInt32(Sale1[0]);
            Amount1 = Convert.ToInt32(Sale1[1]);
            Price1 = Convert.ToDouble(Sale1[2]);

            Console.WriteLine("VALOR A PAGAR: R$ " + ((Amount0 * Price0) + (Amount1 * Price1)).ToString("F2"));

        }
    }
}
