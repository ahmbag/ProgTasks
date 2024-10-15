using System;

namespace Task0304
{
    internal class StraßeBeobachter : IBeobachter
    {
        bool straßeGesperrt = false;

        public bool Straße {  get; set; }
        public void Update(double wasserstand)
        {
            //straße sperren
            if (wasserstand >= 9 && !straßeGesperrt)
            {
                straßeGesperrt = true;
                Console.WriteLine("Straßenwacht: Ich sperre die Straße. Der Wasserstand ist zu hoch");
            }
            else if (wasserstand < 9 && straßeGesperrt) {
                Console.WriteLine("Straßenwacht: Wasserstand ist unter der Schwelle, aber ich kann nicht wieder öffnen");
            }
            else
            {
                Console.WriteLine("Straßenwacht: Nix zu tun");
            }
        }
    }
}
