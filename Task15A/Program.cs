using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kreis k = new Kreis(10, new Punkt(20, 30));

            Console.WriteLine("Umfang: " + k.Umfang());
            Console.WriteLine("Inhalt: " + k.Inhalt());

            Vektor v = new Vektor(new Punkt(0, 0), new Punkt(10, 10));

            Console.WriteLine("Länge: " + v.Laenge());

            Console.ReadLine();
        }
    }
}
