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

        public Rennen(string name, List<Rennschnecke> teilnehmer, int distance)
        {
            _name = name;
            _entrants = teilnehmer.Count;
            _teilnehmer = teilnehmer;
            _distance = distance;
        }

        public void AddRennschnecke(Rennschnecke rennschnecke) { 
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
