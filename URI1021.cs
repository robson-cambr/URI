using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DevCSharp
{
    class URI1021
    {
        static void Uri1021(string[] args)
        {
            double N;
            int Change;
            int Cent;
            int N_Hundred, N_Fifty, N_Twenty, N_Ten, N_Five, N_Two;
            int C_Hundred, C_Fifty, C_TwentyFive, C_Ten, C_Five, C_One;

            N = double.Parse(Console.ReadLine());

            Change = (int) N;
            Cent = (int) ((N - Change) * 100);

            //NOTES

            N_Hundred = (int) Change / 100;
            Change = Change - (N_Hundred * 100);

            N_Fifty = (int) Change / 50;
            Change = Change - (N_Fifty * 50);

            N_Twenty = (int) Change / 20;
            Change = Change - (N_Twenty * 20);

            N_Ten = (int) Change / 10;
            Change = Change - (N_Ten * 10);

            N_Five = (int) Change / 5;
            Change = Change - (N_Five * 5);

            N_Two = (int) Change / 2;
            Change = Change - (N_Two * 2);

            //COINS

            C_Hundred = (int) Change / 1;

            C_Fifty = (int) Cent / 50;
            Cent = Cent % 50;

            C_TwentyFive = (int) Cent / 25;
            Cent = Cent % 25;

            C_Ten = (int) Cent / 10;
            Cent = Cent % 10;

            C_Five = (int) Cent / 5;
            Cent = Cent % 5;

            C_One = (int) Cent / 1;
            Cent = Cent % 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(N_Hundred.ToString() + " nota(s) de R$ 100.00");
            Console.WriteLine(N_Fifty.ToString() + " nota(s) de R$ 50.00");
            Console.WriteLine(N_Twenty.ToString() + " nota(s) de R$ 20.00");
            Console.WriteLine(N_Ten.ToString() + " nota(s) de R$ 10.00");
            Console.WriteLine(N_Five.ToString() + " nota(s) de R$ 5.00");
            Console.WriteLine(N_Two.ToString() + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(C_Hundred.ToString() + " moeda(s) de R$ 1.00");
            Console.WriteLine(C_Fifty.ToString() + " moeda(s) de R$ 0.50");
            Console.WriteLine(C_TwentyFive.ToString() + " moeda(s) de R$ 0.25");
            Console.WriteLine(C_Ten.ToString() + " moeda(s) de R$ 0.10");
            Console.WriteLine(C_Five.ToString() + " moeda(s) de R$ 0.05");
            Console.WriteLine(C_One.ToString() + " moeda(s) de R$ 0.01");
        }
    }
}
