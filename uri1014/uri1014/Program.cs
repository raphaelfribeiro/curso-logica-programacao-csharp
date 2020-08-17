using System;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, consumoMedio;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());
            consumoMedio = X / Y;

            Console.WriteLine(consumoMedio.ToString("F3") + " km/l");
        }
    }
}
