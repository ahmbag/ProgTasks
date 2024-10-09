using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0208
{
    internal class Haustier
    {
        string _name;
        bool _steuerpflichtig;
        double _jahreskostenTierarzt;

        public string GetName() => _name;
        public bool GetSteuer() => _steuerpflichtig;
        public double GetKosten() => _jahreskostenTierarzt;
        public Haustier(string name, bool steuer, double kosten)
        {
            _name = name;
            _steuerpflichtig = steuer;
            _jahreskostenTierarzt = kosten;
        }

        public virtual string Beschreibung()
        {
            return _name + " ist " + (GetSteuer() ? "" : "nicht ") + "steuerpflichtig";
        }
    }
}
