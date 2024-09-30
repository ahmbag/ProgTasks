using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task451
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[50000];
            int[] counts = new int[10];
            var r = new Random();

            for (int i = 0; i < values.Length; i++) {
                values[i] = r.Next(0, 10);
            }

            foreach (int i in values)
            {
                counts[i] ++;
            }

            for(int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine("Häufigkeit von " + i + " ist " + counts[i]);
            }

            Console.ReadLine();
        }
    }
}
