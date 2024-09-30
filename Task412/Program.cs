using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task412
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int sum = 0;

            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 10);
                sum += array1[i];
            }
            Console.WriteLine("\narray1");
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nMittelwert: " + (sum / 10.0));
            Console.WriteLine("Operator eingeben");
            var op = Console.ReadKey().KeyChar;

            if (op == '/' || op == '*' || op == '-' || op == '+')
            {
                double calc = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    if (i == 0)
                    {
                        calc = array1[i];
                    }
                    else if (op == '/')
                    {
                        calc /= array1[i];
                    }
                    else if (op == '*')
                    {
                        calc *= array1[i];
                    }
                    else if (op == '-')
                    {
                        calc -= array1[i];
                    }
                    else if (op == '+')
                    {
                        calc += array1[i];
                    }
                }
                Console.WriteLine("\nErgebnis: " + calc);
            }
            else
            {
                Console.WriteLine("\nERROR - Kein Operator eingegeben");
            }


            return;
        }
    }
}
