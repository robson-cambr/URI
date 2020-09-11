using System;
using System.Collections.Generic;
using System.Text;

namespace DevCSharp
{
    class URI1012
    {
        static void Uri1012(string[] args)
        {                               
            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);
            double r = 3.14159;

            double Triangle = (A * C) / 2, Circle = r * C * C, Y = A + B, Trapeze = Y * C / 2, Square = B * B, Retangle = A * B;

            Console.WriteLine("TRIANGULO: " + Triangle.ToString("F3"));
            Console.WriteLine("CIRCULO: " + Circle.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + Trapeze.ToString("F3"));
            Console.WriteLine("QUADRADO: " + Square.ToString("F3"));
            Console.WriteLine("RETANGULO: " + Retangle.ToString("F3"));
        }
    }
}
