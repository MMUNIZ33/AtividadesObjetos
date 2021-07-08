using System;
using System.Globalization;

namespace A1008_DOLAR
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.Write("Qual a cotação do dólar: ");
            double ValorDolar = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantos dólares você vai comprar? ");
            double Comprar = double.Parse(Console.ReadLine(), CI);

            double ValorFinal = Dolar.ConverterDolar(ValorDolar, Comprar);

            Console.WriteLine("Valor a ser pago em reais = " + ValorFinal.ToString("F2", CI));
        }
    }
}
