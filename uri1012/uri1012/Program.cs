using System;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi, triangulo, circulo, trapezio, quadrado, retangulo;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);
            pi = 3.14159;

            triangulo = (A * C) / 2.0;
            circulo = pi * Math.Pow(C, 2.0);
            trapezio = ((A + B) / 2.0) * C;
            quadrado = Math.Pow(B, 2.0);
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
        }
    }
}
