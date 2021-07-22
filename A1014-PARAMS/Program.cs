using System;

namespace A1014_PARAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            // // ref e out são considerados "code smells" (design ruim). É bom evitar usá-los.
            // // return é mais indicado.
            // int a = 1;
            // int b;
            // Calculator.Triple(a, out b);
            // Console.WriteLine(b);
            
            int s1 = Calculator.Soma(1, 2, 3);
            int s2 = Calculator.Soma(10, 5, 5);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
