using System;

namespace A1002_NOMEIDADE
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas A, B;
            A = new Pessoas();
            B = new Pessoas();

            Console.WriteLine("Dados da primera pessoa:");
            Console.Write("Nome: ");
            A.name = Console.ReadLine();
            Console.Write("Idade: ");
            A.idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            B.name = Console.ReadLine();
            Console.Write("Idade: ");
            B.idade = int.Parse(Console.ReadLine());

            if (A.idade > B.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + A.name);
            }
            else if (A.idade < B.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + B.name);
            }
            else
            {
                Console.WriteLine("Eles tem a mesma idade");
            }


        }
    }
}
