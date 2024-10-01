using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Praktikant : Mitarbeiter
    {
        private Abteilung _abteilung;
              
        public Praktikant(Abteilung abt, string name, string vorname, int alter) 
            : base(name, vorname, alter)
        {
            _abteilung = abt;
        }

        public override double GetGehalt()
        {
            return Convert.ToInt32(_abteilung);
        }
        public override string GetJobName()
        {
            return "Paktikant";
        }

        public override string Ausgabe()
        {
            return GetJobName() + ": " +
                GetName() + " ist " +
                GetAlter() + " Jahre alt und verdient " +
                GetGehalt() + " in der Abteilung " +
                _abteilung;
        }
    }

    public enum Abteilung
    {
        Entwicklung = 935,
        Vertrieb = 820,
        Produktion = 710
    }
}
