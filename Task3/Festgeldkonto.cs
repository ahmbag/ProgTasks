using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Festgeldkonto : Konto
    {
        private DateTime _minDate;

        public Festgeldkonto(string name, string vorname, int kontonummer, double habenszinssatz = 2.0) : base(name, vorname, kontonummer, habenszinssatz)
        {
            _minDate = DateTime.Now.AddYears(2);
        }

        public TimeSpan Restlaufzeit() => _minDate - DateTime.Now;
    }
}
