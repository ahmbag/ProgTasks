using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task0208
{
    internal class Hund : Haustier
    {
        string _rasse;
        public Hund(string name, double kosten, string rasse) : base(name, true, kosten)
        {
            _rasse = rasse;
        }

        public string GetRasse() => _rasse;

        public override string Beschreibung()
        {
            return GetName() + " ist " +
                _rasse + " und ist " +
                (GetSteuer() ? "" : "nicht ") + "steuerpflichtig";
        }
    }
}
