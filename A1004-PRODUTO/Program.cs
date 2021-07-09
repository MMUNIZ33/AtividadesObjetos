using System;
using System.Globalization;

namespace A1004_PRODUTO
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            // Leitura de Dados
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Construtor
            Produto p = new Produto(name, preco, quantidade);

            // Imprimir 1
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados: ");
            int add1 = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(add1);

            // Imprimir 2
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos: ");
            int rmv1 = int.Parse(Console.ReadLine());
            p.RemoverProdutos(rmv1);

            // Imprimir 3
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
        }
    }
}
