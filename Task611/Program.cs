using System;

namespace Task611
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basis?");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Potenz?");
            int n = int.Parse(Console.ReadLine());

            int result = Potenz(a, n);

            Console.WriteLine("Das Ergebnis: " + result);

            Console.ReadLine();
        }

        private static int Potenz(int a, int n)
        {
            if (n == 0) { return 1; }
            else { return a * Potenz(a, n - 1); }
        }
    }
}
