using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Angestellter : Mitarbeiter
    {
        private Tarif tarifgruppe;
              
        public Angestellter(Tarif tarifgruppe, 
            string name, string vorname, int alter) : base(name, vorname, alter)
        {
            this.tarifgruppe = tarifgruppe;
        }

        public override double GetGehalt()
        {
            return Convert.ToInt32(tarifgruppe) * (1 + (((double)GetAlter() - 25) / 100));
        }

        public override string GetJobName() => "Angestellter";

        public override string Ausgabe()
        {
            return GetJobName() + ": " +
                GetName() + " ist " +
                GetAlter() + " Jahre alt und verdient " +
                GetGehalt() + " in der Tarifgruppe " +
                tarifgruppe;
        }

    }
    public enum Tarif
    {
        A = 2560,
        B = 3000,
        C = 3200,
        D = 5400
    }

}
