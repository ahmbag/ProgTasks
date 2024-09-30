using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18A
{
    internal class Wettbuero
    {
        private Rennen _rennen;
        private List<Wette> _wetten = new List<Wette>();
        private int _factor;

        public struct Wette
        {
            public string Schnecke;
            public int Einsatz;
            public string Spieler;
        }

        public Wettbuero(Rennen rennen, int factor, List<Wette> wetten = null) { 
            _rennen = rennen;
            _factor = factor;
            if (wetten != null ) 
                _wetten = wetten;
        }

        public void WetteAnnehmen(string schneckenName, int wettEinsatz, string spieler)
        {
            _wetten.Add(new Wette { Schnecke = schneckenName, Einsatz = wettEinsatz, Spieler = spieler });
        }

        public void RennAblauf()
        {
            _rennen.Durchführen();
        }

        public void Ausgabe()
        {
            foreach (var w in _wetten) {
                Console.WriteLine(w.Spieler + " wettet auf " + w.Schnecke + " mit " + w.Einsatz);
            }

            _rennen.Print();

            var winner = _rennen.ErmittleGewinner();

            Console.WriteLine(winner.GetName() + " hat gewonnen!");

            foreach (var w in _wetten) { 
                if(w.Schnecke == winner.GetName())
                {
                    Console.WriteLine(w.Spieler + " hat " + w.Einsatz * _factor + " gewonnen");
                }
            }
        }
    }
}
