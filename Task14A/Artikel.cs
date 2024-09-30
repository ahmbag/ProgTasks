using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14A
{
    internal class Artikel
    {
        public int id;
        public string bezeichnung;
        public int istbestand;
        public int maxbestand;
        public double preis;
        public int verbrauch;
        public int bestelldauer;

        public int meldebestand { 
            get 
            { 
                return (3 + bestelldauer) * verbrauch; 
            } 
        }
        public int bestellvorschlag
        {
            get
            {
                if (istbestand - meldebestand < 0)
                {
                    return meldebestand - istbestand;
                }
                return 0;
            }
        }

        public void PrintArtikel()
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

            Console.SetCursorPosition(0, id);
            Console.Write(id);

            Console.SetCursorPosition(6, id);
            Console.Write(bezeichnung);

            Console.SetCursorPosition(21, id);
            Console.Write(istbestand);

            Console.SetCursorPosition(35, id);
            Console.Write(maxbestand);

            Console.SetCursorPosition(49, id);
            Console.Write(preis);

            Console.SetCursorPosition(58, id);
            Console.Write(verbrauch);

            Console.SetCursorPosition(71, id);
            Console.Write(bestelldauer);

            Console.SetCursorPosition(87, id);
            Console.Write(meldebestand);

            Console.SetCursorPosition(103, id);
            Console.Write(bestellvorschlag);
        }
    }

}
