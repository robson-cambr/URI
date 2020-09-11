using System;

namespace DevCSharp
{
    class URI1007
    {
        static void Uri1007(string[] args)
        {
            int A, B, C, D, DIFERENCA;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            DIFERENCA = ((A * B) - (C * D));

            Console.WriteLine("DIFERENCA = " + DIFERENCA.ToString());
        }
    }
}
