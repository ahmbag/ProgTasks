using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rennschnecke r1 = new Rennschnecke("super", 5);
            Rennschnecke r2 = new Rennschnecke("mega", 5);
            Rennschnecke r3 = new Rennschnecke("turbo", 5);

            Rennen r = new Rennen("finale", 40, 8);
            r.AddRennschnecke(r1);
            r.AddRennschnecke(r2);
            r.AddRennschnecke(r3);
            r.AddRennschnecke((Rennschnecke)r1.Clone());

            Wettbuero w = new Wettbuero(r, 25);

            w.WetteAnnehmen("super", 10, "Anton");
            w.WetteAnnehmen("mega", 15, "Caesar");
            w.WetteAnnehmen("turbo", 20, "Emil");
            w.WetteAnnehmen("super", -5, "Gerhardt");

            w.RennAblauf();

            w.Ausgabe();

            Console.ReadLine();
        }

    }
}
