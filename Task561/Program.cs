using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task561
{
    internal class Program
    {
        
        static void Main(string[] args)
        {          
            int input = GetAndCheckUserInput();

            string bin = IntToBit(input);

            Console.WriteLine(bin);

            Console.ReadLine();
        }

        static string IntToBit(int input) {
            if (input == 0)
            {
               return("0");
            }

            string bin = "";

            while (input > 0)
            {
                int rest = input % 2;
                bin = rest + bin;
                input /= 2;
            }

            return bin;
        }

        static int GetAndCheckUserInput()
        {
            Console.WriteLine("Positive Ganzzahl eingeben");

            int input = int.Parse(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("Zahl ist negativ!");
                throw new Exception();
            }

            return input;
        }
    }
}
