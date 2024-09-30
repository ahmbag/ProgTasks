using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task12A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Person p1 = new Person("Mustermann", "Max", 17);
            p1.SetAdresse(new Adresse
            {
                Strasse = "Teststr.",
                Hausnummer = "123",
                Postleitzahl = 12345,
                Ort = "Teststadt"
            });
            list.Add(p1);

            Person p2 = new Person("Fletcher", "CT", 45);
            p2.SetAdresse(new Adresse
            {
                Strasse = "Ocean Front Walk",
                Hausnummer = "1800",
                Postleitzahl = 90291,
                Ort = "Los Angeles"
            });
            p2.SetHund(new Hund
            {
                name = "Algo"
            });

            list.Add(p2);

            foreach (Person p in list) { 
                Console.WriteLine("{0} {1} ist {2} Jahre alt.", 
                    p.GetVorname(), p.GetNachname(), p.GetAlter());
                Console.WriteLine("Er wohnt an der {0} {1}", 
                    p.GetAdresse().Strasse, p.GetAdresse().Hausnummer);
                Console.WriteLine("In {0} {1}",
                    p.GetAdresse().Postleitzahl, p.GetAdresse().Ort);
            }
            p2.GetHund().Fuettern();
            p2.GetHund().Gassi(p1);
            p2.GetHund().Gassi(p1);

            Console.ReadLine();
        }
    }

    class Person
    {
        private string nachname;
        private string vorname;
        private int alter;
        private Adresse adresse;
        private Hund hund;
        public Person(string n, string v, int a)
        {
            nachname = n;
            vorname = v;
            alter = a;
        }
        public string GetNachname() => nachname;
        public string GetVorname() => vorname;
        public int GetAlter() => alter;
        public Adresse GetAdresse() => adresse;
        public Hund GetHund() => hund;
        public void SetNachname(string n) => nachname = n;
        public void SetAdresse(Adresse a) => adresse = a;
        public void SetHund(Hund h) => hund = h;
    }

    class Adresse
    {
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public int Postleitzahl { get; set; }
        public string Ort { get; set; }
    }

    class Hund
    {
        public string name { get; set; }
        private bool satt;

        public void Fuettern() => satt = true;
        public bool Gassi(Person p)
        {
            if (p.GetAlter() < 16)
            {
                Console.WriteLine("{0} ist zu Jung, kein gassi!", p.GetVorname());
                return false;
            }

            if (satt) 
            {
                Console.WriteLine("{0} ist satt, gassi gehen!", name);
                satt = false;
                return true; 
            }
            
            Console.WriteLine("{0} hat hunger, kein gassi!", name);
            return false;
        }
    }
}
