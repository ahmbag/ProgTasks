using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task431
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[100000];

            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 50000);
            }

            Console.WriteLine("Bitte zu suchende Zahl eingeben");
            var input = int.Parse(Console.ReadLine());

            bool found = false;
            Dictionary<long,long> ind = new Dictionary<long,long>();
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == input)
                {
                    found = true;
                    ind.Add(i, array1[i]);
                    Console.WriteLine("\nWeitersuchen?");
                    var r = Console.ReadKey().KeyChar;
                    if (r != 'j')
                    {
                        break;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("\nNein, die Zahl ist nicht im Array");
            }
            else
            {
                Console.Write("\nJa, die Zahl ist im Array, Position: ");
                foreach (var i in ind.Keys) {
                    Console.Write(i + " ");
                }
            }


            return;
        }
    }
}
