using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task0208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tiere = Anlegen();

            var neuerVogel = new Vogel("blub", 100000, false);
            foreach (var t in tiere)
            {
                if (NeuerLieblingsvogel(t, neuerVogel))
                {
                    Console.WriteLine(t.GetName() + " ist eine Katze und hat einen neuen Vogel " 
                        + neuerVogel.GetName());
                    break;
                }
            }

            Print(tiere);

            Console.ReadLine();
        }

        public static Haustier[] Anlegen()
        {
            Haustier[] tiere = new Haustier[10];

            tiere[0] = new Hund("bell", 10, "wau");
            tiere[1] = new Katze("miau", 100, new Vogel("tweet", 1000, true));
            tiere[2] = new Vogel("bla", 10000, false);

            return tiere;
        }

        public static bool NeuerLieblingsvogel(Haustier haustier, Vogel v)
        {
            if (haustier.GetType() == typeof(Katze))
            {
                var k = (Katze)haustier;
                k.SetVogel(v);
                return true;
            }

            return false;
        }

        public static void Print(Haustier[] haustiers) {
            double k = 0;
            foreach (var item in haustiers)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Beschreibung());
                    k += item.GetKosten();
                    if (item.GetType() == typeof(Katze)) { 
                        var katze = (Katze)item;
                        k += katze.Vogel().GetKosten();
                    }
                }
            }
            Console.WriteLine("Gesamtkosten: " + k);
        }
    }
}
