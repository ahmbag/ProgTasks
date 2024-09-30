using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nBitte geben sie eine Zahl ein oder R für random");
                
                var input = Console.ReadLine();
                double number;
                if (input.Contains("R"))
                {
                    Random rnd = new Random();
                    number = rnd.Next(-10,10);
                }
                else
                {
                    number = double.Parse(input);
                   
                }

                for (int i = 0; i <= 100; ++i)
                {
                    string line = "\r{0}%   Calculating [";
                    for (int j = 0; j <= Math.Round((i/10.0)); ++j) {
                        line += "0";
                    }
                    for (int j = 0; j < 10 - Math.Round((i / 10.0)); ++j)
                    { 
                        line += "-";
                    }
                    line += "]";
                    Console.Write(line, i);
                    Thread.Sleep(10);
                }

                Console.WriteLine("\nBetrag der Eingabe: " + Math.Abs(number));

                Console.WriteLine("Beliebige Taste drücken für erneute Ausführung, e für exit");
                var resume = Console.ReadKey();

                if (resume.KeyChar == 'e')
                {
                    break;
                }
            }
        }
    }
}
