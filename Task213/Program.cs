using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erster Wert?");
            var first = int.Parse(Console.ReadLine());

            Console.WriteLine("Zweiter Wert?");
            var second = int.Parse(Console.ReadLine());

            Console.WriteLine("Dritter Wert");
            var third = int.Parse(Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine("Wert1 ist größer Wert2: {0} > {1}", first, second);

                if (first > 3)
                {
                    Console.WriteLine("Wert1 ist auch größer 3: {0} > 3", first);
                }
                else
                {
                    Console.WriteLine("Wert1 ist nicht größer 3: {0} < 3", first);
                }
            }
            else if (first > third)
            {
                Console.WriteLine("Wert1 ist größer Wert3: {0} > {1}", first, third);

                if (third < 5)
                {
                    Console.WriteLine("Wert3 ist kleiner 5: {0} < 5", third);
                }
                else if(third < 10)
                {
                    Console.WriteLine("Wert3 ist kleiner 10: {0} < 10", third);
                }
                else
                {
                    Console.WriteLine("Wert3 ist größer 10: {0} > 10", third);
                }
            }
            else
            {
                Console.WriteLine("Keine der Prüfungen ergibt WAHR");
            }

            Console.ReadLine();

            GC.Collect();
        }
    }
}
