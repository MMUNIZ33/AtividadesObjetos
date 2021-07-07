using System;
using System.Globalization;

namespace A1006_SALARIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario A = new Funcionario();
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Nome: ");
            A.Name = Console.ReadLine();
            Console.Write("Salário: ");
            A.SalarioBruto = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            A.Imposto = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"Dados atualizados: " + A);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = 0.0;
            porcent = double.Parse(Console.ReadLine(), CI);
            A.AumentarSalario(porcent);
            
            Console.WriteLine($"Dados atualizados: " + A);

        }
    }
}
