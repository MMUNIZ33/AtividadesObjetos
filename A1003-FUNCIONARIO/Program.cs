using System;
using System.Globalization;

namespace A1003_FUNCIONARIO
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Funcionario A, B;
            A = new Funcionario();
            B = new Funcionario();

            // Funcionário 1
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            A.name = Console.ReadLine();
            Console.Write("Salário: ");
            A.salary = double.Parse(Console.ReadLine(), CI);
            
            // Funcionário 2
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            B.name = Console.ReadLine();
            Console.Write("Idade: ");
            B.salary = double.Parse(Console.ReadLine(), CI);

            var media = 0.0;
            media = (A.salary + B.salary) / 2.0;
            Console.WriteLine("Salário médio: " + media.ToString("F2", CI));
        }
    }
}
