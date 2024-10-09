using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0207
{
    internal class Pickup : Auto
    {
        int _Fassungsvermögen;
        int _Beladung;
        public Pickup(int fassung, string kennzeichen = "DO-OM 3") : base(2, kennzeichen) 
        {
            _Fassungsvermögen = fassung;
            _Beladung = 0;
        }

        public int GetLadung() => _Beladung;

        public bool Beladen(int ladungsMenge)
        {
            if (_Fassungsvermögen - _Beladung - ladungsMenge >= 0)
            {
                _Beladung += ladungsMenge;
                Console.WriteLine("wurde verladen");
                return true;
            }
            Console.WriteLine("nicht genügend Platz");
            return false;
        }

        public bool Entladen(int ladungsMenge)
        {
            if(_Beladung >= ladungsMenge)
            {
                _Beladung -= ladungsMenge;
                Console.WriteLine("wurde entladen");
                return true;
            }
            Console.WriteLine("nicht genügend Ladung");
            return false;
        }

        public override void VorDemWaschen()
        {
            AntenneEinfahren();
            Entladen(_Beladung);
        }

        public override string ToString()
        {
            return "";
        }
    }
}
