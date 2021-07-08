using System;
using System.Globalization;

namespace A1009_STATIC
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.Write("Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("CIRCUNFERÊNCIA: " + circ.ToString("F2", CI));
            Console.WriteLine("VOLUME: " + volume.ToString("F2", CI));
            Console.WriteLine("VALOR DE PI: " + Calculadora.Pi.ToString("F2", CI));
        }
    }
}
