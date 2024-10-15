using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0304
{
    internal class Wasserstand
    {
        double stand;
        List<IBeobachter> beobachters = new List<IBeobachter>();

        public void SetWasserstand(double s) { stand = s;
            Console.WriteLine("Neuer Wasserstand: " + s + " m");
        }

        public double GetWasserstand() => stand;

        public void AddBeobachter(IBeobachter beobachter) => beobachters.Add(beobachter);

        public void RemoveBeobachter(IBeobachter beobachter) => beobachters.Remove(beobachter); 

        public void BenachrichtigeBeobachter()
        {
            foreach(var beobachter in beobachters)
            {
                beobachter.Update(stand);
            }
        }
    }
}
