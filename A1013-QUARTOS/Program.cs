using System;

namespace A1013_QUARTOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] quarts = new Quartos[10];
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nRent #" + (i + 1) + ":");
                Console.Write("Nome: ");
                var nome = Console.ReadLine();
                Console.Write("Email: ");
                var email = Console.ReadLine();
                Console.Write("Quarto: ");
                var quarto = int.Parse(Console.ReadLine());
                quarts[quarto] = new Quartos (nome, email, quarto);
            }
            for (int i = 0; i < 10; i++)
            {
                if (quarts[i] != null)
                {
                    Console.WriteLine(i + ": " + quarts[i]);
                }
            }

        }
    }
}
