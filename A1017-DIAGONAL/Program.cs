using System;

namespace A1016_DIAGONAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            int n = int.Parse(Console.ReadLine());
            int[,] mtz = new int[n, n];
            string[] s;

            // Atribuir valores
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mtz[i, j] = int.Parse(s[j]);
                }
            }

            // imprimir diagonal
            System.Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mtz[i, j] + " ");
                    } 
                }
            }
            
            Console.WriteLine();
            int negativ = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mtz[i, j] < 0)
                    {
                        negativ ++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + negativ);
        }
    }
}
