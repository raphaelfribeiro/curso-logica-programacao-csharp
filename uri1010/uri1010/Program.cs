using System;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            string[] vet1, vet2;
            
            vet1 = Console.ReadLine().Split(' ');
            vet2 = Console.ReadLine().Split(' ');
            valor = (double.Parse(vet1[1]) * double.Parse(vet1[2])) + (double.Parse(vet2[1]) * double.Parse(vet2[2]));

            Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2"));            
        }
    }
}
