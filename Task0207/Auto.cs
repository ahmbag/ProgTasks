using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0207
{
    internal class Auto
    {
        string _Kennzeichen;
        int _Kilometerstand;
        int _Sitze;
        bool _antenneAusgefahren = false;
        public string GetKennzeichen() => _Kennzeichen;
        public int GetKilometerstand() => _Kilometerstand;
        public int GetSitzplätze() => _Sitze;
        public bool IstAntenneDraussen() => _antenneAusgefahren;

        public void Fahre(int kilometer) => _Kilometerstand += kilometer;

        public void AntenneEinfahren()
        {
            if(_antenneAusgefahren)
                Console.WriteLine("Antenne eingefahren");
                _antenneAusgefahren = false;
        }

        public void AntenneAusfahren()
        {
            if(!_antenneAusgefahren)
                Console.WriteLine("Antenne ausgefahren");
                _antenneAusgefahren = true;
        }

        public virtual void VorDemWaschen() => AntenneEinfahren();

        public void Waschen()
        {
            VorDemWaschen();
            Console.WriteLine("Auto wird gewaschen");
        }

        public Auto(int sitze = 5, string kennzeichen = "DO-OM 3") { 
            _Kennzeichen=kennzeichen;
            _Sitze=sitze;
            _Kilometerstand = 0;
        }

        public bool TriggerAntenne()
        {
            _antenneAusgefahren = !_antenneAusgefahren;
            return _antenneAusgefahren;
        }

        public override string ToString()
        {
            return _Kennzeichen + "";
        }
    }
}
