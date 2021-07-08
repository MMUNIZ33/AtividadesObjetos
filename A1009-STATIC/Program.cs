using System;
using System.Globalization;

namespace A1009_STATIC
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.Write("Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("CIRCUNFERÊNCIA: " + circ.ToString("F2", CI));
            Console.WriteLine("VOLUME: " + volume.ToString("F2", CI));
            Console.WriteLine("VALOR DE PI: " + Pi.ToString("F2", CI));

        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
