using System;
using System.Collections.Generic;

namespace A1016_LISTS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Matheus");
            list.Add("Amanda");
            list.Add("Felipe");
            list.Add("João");
            list.Add("Anna");
            list.Insert(2, "Lucas");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Tamanho da lista: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro com A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último com A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); 
            Console.WriteLine("Posição primeiro com A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); 
            Console.WriteLine("Posição Último com A: " + pos2);

            Console.WriteLine("-----------------------");

            List<string> list_filtro = list.FindAll(x => x.Length== 5);

            foreach (var item in list_filtro)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");

            list.Remove("João");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("-----------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");
            list.RemoveAt(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");
            
            list.RemoveRange(1, 2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
