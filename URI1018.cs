using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1018
    {
        static void Uri1018(string[] args)
        {
            int N;
            int Change;
            int Hundred, Fifty, Twenty, Ten, Five, Two, One;

            N = int.Parse(Console.ReadLine());

            Change = N;

            Hundred = Change / 100;
            Change = Change - (Hundred * 100);

            Fifty = Change / 50;
            Change = Change - (Fifty * 50);

            Twenty = Change / 20;
            Change = Change - (Twenty * 20);

            Ten = Change / 10;
            Change = Change - (Ten * 10);

            Five = Change / 5;
            Change = Change - (Five * 5);

            Two = Change / 2;
            Change = Change - (Two * 2);

            One = Change / 1;
            Change = Change - (One * 1);

            Console.WriteLine(N.ToString());
            Console.WriteLine(Hundred.ToString() + " nota (s) de R$ 100,00");
            Console.WriteLine(Fifty.ToString() + " nota (s) de R$ 50,00");
            Console.WriteLine(Twenty.ToString() + " nota (s) de R$ 20,00");
            Console.WriteLine(Ten.ToString() + " nota (s) de R$ 10,00");
            Console.WriteLine(Five.ToString() + " nota (s) de R$ 5,00");
            Console.WriteLine(Two.ToString() + " nota (s) de R$ 2,00");
            Console.WriteLine(One.ToString() + " nota (s) de R$ 1,00");

        }
    }
}
