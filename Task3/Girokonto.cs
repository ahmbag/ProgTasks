using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Girokonto : Konto
    {
        private double _dispo;
        private double _sollzinsen = 16.0;
        private Kategorie _kategorie;

        public Girokonto(Kategorie k, double dispo, string name, string vorname, int kontonummer, double habenszinssatz = 0.0) : base(name, vorname, kontonummer, habenszinssatz)
        {
            _dispo = dispo;
            _kategorie = k;
        }
    }

    enum Kategorie
    {
        Standard,
        Schüler,
        Student,
        Gewerblich
    }
}
