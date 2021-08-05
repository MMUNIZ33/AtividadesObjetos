using System;
namespace A1017_DIAGONAL
{
    class Matrizz
    {   
        static int n;
        static int[,] mtz;
        static string[] s;

        public static void Ler()
        {
            Console.WriteLine("Input:");
            n = int.Parse(Console.ReadLine());
            mtz = new int[n, n];
        }
        
        public static void Atribuir()
        {
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mtz[i, j] = int.Parse(s[j]);
                }
            }
        }

        public static void Imprimir()
        {
            Console.WriteLine("Main diagonal:");
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