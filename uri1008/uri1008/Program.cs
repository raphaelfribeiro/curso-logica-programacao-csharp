using System;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, numeroHorasTrabalhadas;
            double valorHora, salario;

            numeroFuncionario = int.Parse(Console.ReadLine());
            numeroHorasTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine());

            salario = (numeroHorasTrabalhadas * valorHora);

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}
