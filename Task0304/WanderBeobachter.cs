using System;

namespace Task0304
{
    internal class WanderBeobachter : IBeobachter
    {
        bool flussDurchquerbar = false;
        bool überschwemmt = false;
        public bool FlussDurchquerbar { get; set; }
        public bool Überschwemmt { get; set; }
        public void Update(double wasserstand)
        {
            //fluss durchqueren
            if (wasserstand <= 1)
            {
                flussDurchquerbar = true;
                überschwemmt = false;
                Console.WriteLine("Wanderwacht: Fahrt alle über den Fluss!");
            }
            //fluss nicht durchqueren
            else if (wasserstand > 1 && wasserstand < 6)
            {
                flussDurchquerbar = false;
                überschwemmt = false;
                Console.WriteLine("Wanderwacht: Fahrt alle neben dem Fluss!");
            }
            //überschwemmt
            else 
            {
                flussDurchquerbar = false;
                überschwemmt = true;
                Console.WriteLine("Wanderwacht: Bleibt vom Wasser fern!");
            }
        }
    }
}
