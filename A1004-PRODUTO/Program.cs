using System;
using System.Globalization;

namespace A1004_PRODUTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto a = new Produto();
            CultureInfo CI = CultureInfo.InvariantCulture;

            // Leitura de Dados
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            a.name = Console.ReadLine();
            Console.Write("Preço: ");
            a.preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade: ");
            a.quantidade = int.Parse(Console.ReadLine());

            // Imprimir 1
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + a);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados: ");
            int add1 = int.Parse(Console.ReadLine());
            a.AdicionarProdutos(add1);

            // Imprimir 2
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + a);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos: ");
            int rmv1 = int.Parse(Console.ReadLine());
            a.RemoverProdutos(rmv1);

            // Imprimir 3
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + a);
            Console.WriteLine();
        }
    }
}
