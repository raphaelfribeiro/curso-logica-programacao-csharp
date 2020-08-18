using System;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, media;

            valor1 = double.Parse(Console.ReadLine());
            valor2 = double.Parse(Console.ReadLine());
            media = ((valor1 * 3.5) + (valor2 * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
}