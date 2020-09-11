using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1114
    {
        static void Uri1134(string[] args)
        {
            int UserPW = 2002;
            int InputPW = int.Parse(Console.ReadLine());

            while (InputPW != UserPW)
            {
                Console.WriteLine("Senha Invalida");
                InputPW = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
