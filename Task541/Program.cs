using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task541
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte zu verschlüsselnden Text eingeben");

            string input = Console.ReadLine();
            string output = "";

            var before = DateTime.Now.Ticks;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    output += input[i + 1];
                    output += input[i];
                }
            }
            var after = DateTime.Now.Ticks;

            Console.WriteLine(output);
            Console.WriteLine("Ticks: " + (after-before));
            Console.ReadLine();

        }
    }
}
