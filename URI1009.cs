using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1009
    {
        static void Uri1009(string[] args)
        {
            string Name;
            double Salary;
            double Bonus;

            Name = Console.ReadLine();
            Salary = double.Parse(Console.ReadLine());
            Bonus = double.Parse(Console.ReadLine());

            double Total = Salary + (15 * Bonus) / 100;

            Console.WriteLine("TOTAL = " + Total.ToString("F2"));
        }
    }
}
