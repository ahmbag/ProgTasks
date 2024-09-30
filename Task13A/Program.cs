using System;
using System.Collections.Generic;

namespace Task13A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Krankenkasse> kassen = new List<Krankenkasse>();
            List<Patient> patients = new List<Patient>();   
            Krankenkasse k1 = new Krankenkasse(123, "ABC");
            Krankenkasse k2 = new Krankenkasse(234, "XYZ");
            kassen.Add(k1);
            kassen.Add(k2);

            Patient p1 = new Patient("Heinrich B");
            p1.Register(12345, k1);
            k1.AddPatient(p1);
            p1.SetAdresse(new Adresse
            {
                Strasse = "Bla",
                Hausnummer = "1a",
                Postleitzahl = 12345,
                Ort = "Blahausen"
            });
            p1.SetGeb(new DateTime(2000, 12, 12));
            patients.Add(p1);

            Patient p2 = new Patient("Berta C");
            p2.Register(23456, k2);
            k2.AddPatient(p2);
            p2.SetAdresse(new Adresse
            {
                Strasse = "Blub",
                Hausnummer = "1a",
                Postleitzahl = 12345,
                Ort = "Blubhausen"
            });
            p2.SetGeb(new DateTime(1990, 12, 12));
            patients.Add(p2);

            Patient p3 = new Patient("Anton D");
            p3.Register(34567, k1);
            k1.AddPatient(p3);
            p3.SetAdresse(new Adresse
            {
                Strasse = "Katz",
                Hausnummer = "1a",
                Postleitzahl = 12345,
                Ort = "Katzhausen"
            });
            p3.SetGeb(new DateTime(1980, 12, 12));
            patients.Add(p3);

            kassen.ForEach(x => x.PrintKrankenkasse());
            patients.ForEach(x => x.PrintPatient());

            Console.ReadLine();
        }                
    }

    class Patient
    {
        private Krankenkasse Krankenkasse;
        private int id;
        private string patientenname;
        private Adresse adresse;
        private DateTime geburtstag;
        private bool cardshown;

        public Patient(string n) {
            patientenname = n;
            cardshown = true;
        }

        public void Register(int i, Krankenkasse k)
        {
            id = i;
            Krankenkasse = k;
        }

        public string GetName() => patientenname ?? string.Empty;

        public void SetAdresse(Adresse a) => adresse = a;
        public void SetGeb(DateTime gb) => geburtstag = gb;

        internal void PrintPatient()
        {
            Console.WriteLine("Patient:");
            Console.WriteLine("Name: " + patientenname);
            Console.WriteLine("Versichertennummer: " + id);
            Console.WriteLine("Adresse: {0} {1} in {2} {3}", 
                adresse.Strasse, adresse.Hausnummer, adresse.Postleitzahl, adresse.Ort);
            Console.WriteLine("Geburtstag: " + geburtstag.ToString());
            Console.WriteLine("Karte vorgelegt? " + (cardshown ? "ja" : "nein"));
            Console.WriteLine("Krankenkasse: " + Krankenkasse.kassenname);
            Console.WriteLine();
        }
    }

    class Adresse
    {
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public int Postleitzahl { get; set; }
        public string Ort { get; set; }
    }

    class Krankenkasse
    {
        private List<Patient> patients { get; set; }
        public int kassennummer { get; set; }
        public string kassenname { get; set; }

        public Krankenkasse(int num, string nam) { 
            patients = new List<Patient>();
            kassennummer = num;
            kassenname = nam;
        }

        public void AddPatient(Patient p) => patients.Add(p);

        public void PrintKrankenkasse()
        {
            Console.WriteLine("Krankenkassenname: " + kassenname);
            Console.WriteLine("Krankenkassennummer: " + kassennummer);
            foreach (var p in patients)
            {
                Console.WriteLine("Mitglied: " + p.GetName());
            }
            Console.WriteLine();
        }
    }
}
