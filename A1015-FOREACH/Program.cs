using System;

namespace A1015_FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = new string[] { "Matheus", "Felipe", "James", "Lilian"};

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.WriteLine("---------------------------------");

            foreach (var item in vet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
