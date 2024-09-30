using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task621
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erste Zahl?");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Zweite Zahl?");
            int b = int.Parse(Console.ReadLine());

            int result = GGT(a, b);

            Console.WriteLine("GGT: " + result);    
            Console.ReadLine();
        }

        private static int GGT(int a, int b)
        {
            if (b == 0) { return a; }
            else { return GGT(b, a%b); }
        }
    }
}
