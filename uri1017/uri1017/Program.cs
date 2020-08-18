using System;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto, velocidadeMedia;
            double quantidadeLitros;

            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());
            quantidadeLitros = ((double)tempoGasto * (double)velocidadeMedia) / 12;

            Console.WriteLine(quantidadeLitros.ToString("F3"));
        }
    }
}
