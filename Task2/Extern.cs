using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Extern : Mitarbeiter
    {
        private int _stunden;

        public Extern(string name, string vorname, int alter) : base(name, vorname, alter) { }

        public override double GetGehalt() => _stunden * 75;
        
        internal void AddWorked(int v) => _stunden += v;

        public override string GetJobName()
        {
            return "Extern";
        }

        public override string Ausgabe()
        {
            return GetJobName() + ": " +
                GetName() + " ist " +
                GetAlter() + " Jahre alt und verdient " +
                GetGehalt() + " und hat " + 
                _stunden + " Stunden gearbeitet.";
        }
    }
}
