using System;
using System.Globalization;

namespace A1012_VET2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int n = int.Parse(Console.ReadLine());
            Product[] vet = new Product[n]; 

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CI);
                vet[i] = new Product { Name = name, Preco = price };  
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Preco;
            }
            double media = soma / n;
            Console.WriteLine("PREÇO MÉDIO = " + media.ToString("F2", CI));

        }
    }
}
