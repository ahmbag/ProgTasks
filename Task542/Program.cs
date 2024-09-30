using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task542
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name-Wert-Paar eingeben!");

            string input = Console.ReadLine();

            if (!input.Contains("="))
            {
                Console.WriteLine("Ungültige Eingabe!");
            }
            else
            {
                string key = input.Split('=')[0];
                string value = input.Split('=')[1];

                Console.WriteLine("Eingabe: " + input + " hat Länge "+ input.Length);
                Console.WriteLine("Key: " + key + " hat Länge " + key.Length);
                Console.WriteLine("Value: " + value + " hat Länge " + value.Length);
            }

            Console.ReadLine();
        }
    }
}
