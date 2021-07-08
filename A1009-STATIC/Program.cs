using System;
using System.Globalization;

namespace A1009_STATIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.Write("Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("CIRCUNFERÊNCIA: " + circ.ToString("F2", CI));
            Console.WriteLine("VOLUME: " + volume.ToString("F2", CI));
            Console.WriteLine("VALOR DE PI: " + calc.Pi.ToString("F2", CI));
        }
    }
}
