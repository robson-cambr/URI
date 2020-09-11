using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace DevCSharp
{
    class URI1067
    {
        static void Uri1067(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            for (int i = 0; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
