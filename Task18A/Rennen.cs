using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18A
{
    internal class Rennen
    {
        private string _name;
        private int _entrants;
        private List<Rennschnecke> _teilnehmer = new List<Rennschnecke>();
        private int _distance;

        public Rennen(string name, int distance, int entrants, List<Rennschnecke> teilnehmer = null)
        {
            _name = name;
            _entrants = entrants;
            if(teilnehmer != null) 
                _teilnehmer = teilnehmer;
            _distance = distance;
        }

        public void AddRennschnecke(Rennschnecke rennschnecke) { 
            if(_entrants == _teilnehmer.Count)
            {
                Console.WriteLine("Alle Plätze belegt");
                return;
            }

            //if(_teilnehmer.Find(x => x.GetName() == rennschnecke.GetName()) != null){
            //    Console.WriteLine("Schnecke bereits registriert: " + rennschnecke.GetName());
            //    return;
            //}
            _teilnehmer.Add(rennschnecke);
            _entrants++;
        }

        public void Print()
        {
            Console.WriteLine("Rennen: " + _name);
            int c = 0;
            foreach (var r in _teilnehmer) {
                Console.WriteLine("Teilnehmer: " + r.ToString());
            }
        }

        public Rennschnecke ErmittleGewinner()
        {
            foreach(var r in _teilnehmer)
            {
                if(r.GetDistance() > _distance)
                {
                    return r;
                }
            }

            return null;
        }

        public void LasseSchneckenKriechen()
        {
            foreach (var r in _teilnehmer)
            {
                r.Krieche();
            }
        }

        public void Durchführen()
        {
            while (ErmittleGewinner() == null)
            {
                LasseSchneckenKriechen();
                Print();
            }
        }

        public bool IstRennteilnehmer(string schneckenName)
        {
            foreach (var r in _teilnehmer)
            {
                if(r.GetName() == schneckenName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
