using System;
using System.Globalization;

namespace A1011_VET
{
    class Program
    {
        static void Main(string[] args)
        {
            // APENAS REVISÃO
            CultureInfo CI = CultureInfo.InvariantCulture;
            double soma = 0.0;

            int N = int.Parse(Console.ReadLine());
            double[] x = new double[N];

            for (int i = 0; i < N; i++)
            {
                x[i] = double.Parse(Console.ReadLine(), CI);
                soma += x[i];
            }

            double media = soma / N;
            Console.WriteLine("ALTURA MÉDIA = " + media.ToString("F2", CI));
        }
    }
}
