using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1020
    {
        static void Uri1020(string[] args)
        {
            int AgeInDays, Year, Month, Day;

            AgeInDays = int.Parse(Console.ReadLine());

            Year = AgeInDays / 365;
            Month = (AgeInDays % 365) / 30;
            Day = (AgeInDays % 365) % 30;

            Console.WriteLine(Year.ToString() + " ano (s)");
            Console.WriteLine(Month.ToString() + " mes (es)");
            Console.WriteLine(Day.ToString() + " dia (s)");

        }
    }
}
