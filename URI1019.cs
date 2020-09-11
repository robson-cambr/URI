using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1019
    {
        static void Uri1019(string[] args)
        {
            int N;
            
            N = int.Parse(Console.ReadLine());

            int Horas = N / 3600;
            int Restante = N % 3600;
            int Minutos = Restante / 60;
            int Segundos = Restante % 60;

            Console.WriteLine(Horas + ":" + Minutos + ":" + Segundos);

        }
    }
}
