using System;

namespace E1003_MTZPOSITION
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, L, C;
            int[,] matrz;
            string[] s;
            // Proporção da matriz
            s = Console.ReadLine().Split(' ');
            L = int.Parse(s[0]);
            C = int.Parse(s[1]);
            matrz = new int[L, C];

            // Leitura da matriz
            for (int i = 0; i < L; i++)
            {   
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    matrz[i, j] = int.Parse(s[j]);
                }
            }

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (n == matrz[i, j])
                    {
                        Console.Write("Posição: ");
                        Console.WriteLine($"{i},{j}");
                        
                        // refazer as condições
                        if (j > 0)
                        {
                            Console.Write("Esquerda: " + matrz[i, (j + 1)]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Direita: " + matrz[i, j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Em cima: ");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Em baixo: ");
                        }
                    }
                }
            }

        }
    }
}
