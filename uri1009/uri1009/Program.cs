using System;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioFixo, totalVendas, totalFinal;

            Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine());
            totalVendas = double.Parse(Console.ReadLine());
            totalFinal = salarioFixo + (totalVendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + totalFinal.ToString("F2"));
        }
    }
}
