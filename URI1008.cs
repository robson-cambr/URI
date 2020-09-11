using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1008
    {
        static void Uri1008(string[] args)
        {
            int EmployeeNumber;
            int WorkTime;
            double WorkValue;

            EmployeeNumber = int.Parse(Console.ReadLine());
            WorkTime = int.Parse(Console.ReadLine());
            WorkValue = double.Parse(Console.ReadLine());

            double Salary = (WorkTime * WorkValue);

            Console.WriteLine("NUMBER = " + EmployeeNumber.ToString());
            Console.WriteLine("SALARY = U$ " + Salary.ToString("F2"));

        }
    }
}
