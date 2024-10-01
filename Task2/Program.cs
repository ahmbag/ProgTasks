using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angestellter a = new Angestellter(Tarif.A, "Anton", "Bauer", 45);
            Angestellter a2 = new Angestellter(Tarif.D, "Dagobert", "Duck", 65);

            Console.WriteLine(a.Ausgabe());

            Console.WriteLine(a2.Ausgabe());

            Extern e = new Extern("Caesar", "Einhorn", 18);
            Extern e2 = new Extern("Spider", "Man", 25);

            e.AddWorked(5);
            e2.AddWorked(50);

            Console.WriteLine(e.Ausgabe());
            Console.WriteLine(e2.Ausgabe());

            Praktikant p = new Praktikant(Abteilung.Entwicklung, "Ferdinand", "Giraff", 75);
            Praktikant p2 = new Praktikant(Abteilung.Produktion, "Iron", "Man", 5);

            Console.WriteLine(p.Ausgabe());
            Console.WriteLine(p2.Ausgabe());

            Console.ReadLine();
        }
    }
}
