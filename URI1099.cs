using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DevCSharp
{
    class URI1099
    {
        static void Uri1099(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] T = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int X = int.Parse(vet[0]), Y = int.Parse(vet[1]);
                int S = 0;

                if (X < Y)
                {
                    for (int J = X; J < Y; J++)
                    {
                        if (J % 2 != 0)
                        {
                            S += J;
                        }
                    }
                }
                else
                {
                    for (int J = Y + 1; J < X; J++)
                    {
                        if (J % 2 != 0)
                        {
                            S += J;
                        }
                    }
                }
                T[i] = S;
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(T[i]);
            }
        }
    }
}

