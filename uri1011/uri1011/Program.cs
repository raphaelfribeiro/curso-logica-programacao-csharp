using System;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, pi, volume;

            R = double.Parse(Console.ReadLine());
            pi = 3.14159;
            volume = (4 / 3.0) * pi * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
        }
    }
}
