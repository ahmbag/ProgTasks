using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Task14A
{
    internal class Warenlager
    {
        public List<Artikel> lager = new List<Artikel>();
        public static int lastId = 0;

        public void AddArtikel(Artikel artikel)
        {
            artikel.id = generateId();
            lager.Add(artikel);
        }

        static int generateId()
        {
            return Interlocked.Increment(ref lastId);
        }

        public void SaveToFile()
        {
            string jsonstring = JsonConvert.SerializeObject(this);
            File.WriteAllText("data.txt", jsonstring);
        }

        public void LoadFromFile()
        {
            if (File.Exists("data.txt"))
            {
                var data = JsonConvert.DeserializeObject<Warenlager>(File.ReadAllText("data.txt"));
                lager = data.lager;
                lastId = data.lager.Count;
            }
        }

        public void PrintReport()
        {
            Console.WriteLine("id    " +
                "Bezeichnung    " +
                "Istbestand    " +
                "Maxbestand    " +
                "Preis    " +
                "Verbrauch    " +
                "Bestelldauer    " +
                "Meldebestand    " +
                "Bestellvorschlag");
            lager.ForEach(x =>
            {
                Console.SetCursorPosition(0, x.id);
                Console.Write(x.id);

                Console.SetCursorPosition(6, x.id);
                Console.Write(x.bezeichnung);

                Console.SetCursorPosition(21, x.id);
                Console.Write(x.istbestand);

                Console.SetCursorPosition(35, x.id);
                Console.Write(x.maxbestand);

                Console.SetCursorPosition(49, x.id);
                Console.Write(x.preis);

                Console.SetCursorPosition(58, x.id);
                Console.Write(x.verbrauch);

                Console.SetCursorPosition(71, x.id);
                Console.Write(x.bestelldauer);

                Console.SetCursorPosition(87, x.id);
                Console.Write(x.meldebestand);

                Console.SetCursorPosition(103, x.id);
                Console.Write(x.bestellvorschlag);
            });
        }        

        public double LagerWert()
        {
            return lager.Sum(x => (x.istbestand * x.preis));
        }
    }

}
