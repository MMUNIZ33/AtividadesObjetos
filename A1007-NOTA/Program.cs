using System;
using System.Globalization;

namespace A1007_NOTA
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Aluno alunu = new Aluno();

            // Leitura
            Console.Write("Nome do aluno: ");
            alunu.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            alunu.Nota1 = double.Parse(Console.ReadLine(), CI);
            alunu.Nota2 = double.Parse(Console.ReadLine(), CI);
            alunu.Nota3 = double.Parse(Console.ReadLine(), CI);

            // Imprimir
            Console.WriteLine();
            Console.WriteLine("NOTA FINAL = " + alunu.NotaFinal().ToString("F2", CI));
            alunu.Aprovaçao();
        }
    }
}
