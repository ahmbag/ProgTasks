using System;

namespace Task14A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warenlager warenlager = new Warenlager();

            warenlager.LoadFromFile();

            warenlager.PrintReport();
            warenlager.lager.Find(x => x.verbrauch == 5)

            //warenlager.lager.FirstOrDefault().PrintArtikel();

            //warenlager.AddArtikel(new Artikel
            //{
            //    bezeichnung = "Teppich",
            //    istbestand = 1,
            //    maxbestand = 100,
            //    preis = 49.9,
            //    verbrauch = 2,
            //    bestelldauer = 3
            //});
            //warenlager.SaveToFile();

            var wert = warenlager.LagerWert();

            Console.ReadLine();
        }
    }
}
