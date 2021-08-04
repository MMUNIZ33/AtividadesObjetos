using System;
using System.Collections.Generic;

namespace E1002_EMPLY
{
    class Sistema
    {
        static List<Funcionario> list = new List<Funcionario>();
        public static void Cadastro()
        {
            Console.Write("Quantos funcionários serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nFuncionário #" + (i + 1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Funcionario(id, name, salary));
            } 
        }

        public static void Aumento()
        {
            Console.WriteLine("Entre com o ID do funcionário que vai receber o aumento: ");
            int searchID = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == searchID);
            if (emp != null)
            {
                Console.WriteLine("Entre com a porcentagem: ");
                double porcentage = double.Parse(Console.ReadLine());
                emp.AlterarSalary(porcentage);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public static void ShowList()
        {
            Console.WriteLine("Lista de funcionários atualizada:");
            foreach (Funcionario item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}