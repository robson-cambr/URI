using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DevCSharp
{
    class URI1061
    {
        static void Uri1061(string[] args)
        {
            int InitialDay, InitialHour, InitialMinute, InitialSecond;
            int EndDay, EndHour, EndMinute, EndSecond;

            string[] InitialTime;
            string[] EndTime;

            Console.Write("Dia " );

            InitialDay = int.Parse(Console.ReadLine());

            InitialTime = Console.ReadLine().Split(":");
            InitialHour = Convert.ToInt32(InitialTime[0]);
            InitialMinute = Convert.ToInt32(InitialTime[1]);
            InitialSecond = Convert.ToInt32(InitialTime[2]);

            Console.Write("Dia ");

            EndDay = int.Parse(Console.ReadLine());

            EndTime = Console.ReadLine().Split(":");
            EndHour = Convert.ToInt32(InitialTime[0]);
            EndMinute = Convert.ToInt32(InitialTime[1]);
            EndSecond = Convert.ToInt32(InitialTime[2]);

            InitialDay = EndDay - InitialDay;
            InitialHour = EndHour - InitialHour;
            InitialMinute = EndMinute - InitialMinute;
            InitialSecond = EndSecond - InitialSecond;

            {

                if (InitialSecond < 0)
                {
                    InitialSecond += 60;
                    InitialMinute--;
                }

                if (InitialMinute < 0)
                {
                    InitialMinute += 60;
                    InitialHour--;
                }

                if (InitialHour < 0)
                {
                    InitialHour += 24;
                    InitialDay--;
                }

            }

            Console.WriteLine(InitialDay + " dia(s)");
            Console.WriteLine(InitialHour + "hora(s)");
            Console.WriteLine(InitialMinute + " minuto(s)");
            Console.WriteLine(InitialSecond + " segundo(s)");
        }
    }
}
