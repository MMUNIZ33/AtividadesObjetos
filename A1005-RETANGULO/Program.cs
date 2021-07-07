using System;
using System.Globalization;

namespace A1005_RETANGULO
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Retangulo A = new Retangulo();
            Console.WriteLine("Entre com a Largura e Altura do retângulo:");
            A.Largura = double.Parse(Console.ReadLine(), CI);
            A.Altura = double.Parse(Console.ReadLine(), CI);

            // Calcular Área
            Console.WriteLine("ÁREA: " + A.Area().ToString("F2", CI));
            Console.WriteLine("PERÍMETRO: " + A.Perimetro().ToString("F2", CI));
            Console.WriteLine("DIAGONAL: " + A.Diagonal().ToString("F2", CI));
        }
    }
}
