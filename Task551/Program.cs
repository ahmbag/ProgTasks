using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task551
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte zu prüfenden Text eingeben");

            string input = Console.ReadLine();

            input = input.ToLower();
            input = input.Replace(" ", "");
            input = input.Replace(",", "");
            input = input.Replace(".", "");
            input = input.Replace("!", "");
            input = input.Replace("-", "");
            input = input.Replace("'", "");

            string check="";

            for (int i = 0; i < input.Length; i++)
            {
                check += input[input.Length-i-1];
            }

            var response = check == input ? "true" : "false";
            Console.WriteLine(response);


            Console.ReadLine();
        }
    }
}
