using System;
using System.Globalization;

namespace A1010_CONTAB
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            var depositoI = 0.0;
            ContaBancaria CB;

            Console.Write("Entre com o número da conta: ");
            var numeroCont = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            var name = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char sn = char.Parse(Console.ReadLine());

            if (sn == 's' || sn == 'S')
            {
                Console.Write("\nEntre com o valor de depósito inicial: ");
                depositoI = double.Parse(Console.ReadLine(), CI);
                CB = new ContaBancaria(numeroCont, name, depositoI);
            }
            else
            {
                CB = new ContaBancaria(numeroCont, name);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(CB);

            // Depósito
            Console.Write("\nValor de depósito: ");
            depositoI = double.Parse(Console.ReadLine(), CI);
            CB.Deposito(depositoI);
            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(CB);

            // Saque
            Console.Write("\nValor de saque: ");
            depositoI = double.Parse(Console.ReadLine(), CI);
            CB.Saque(depositoI);
            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(CB);
        }
    }
}
