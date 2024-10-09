using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0208
{
    internal class Katze : Haustier
    {
        Vogel _lieblingsVogel;

        public Katze(string name, double kosten, Vogel lieblingsVogel) : base(name, false, kosten)
        {
            _lieblingsVogel = lieblingsVogel;
        }

        public Vogel Vogel() => _lieblingsVogel;
        public void SetVogel(Vogel v) => _lieblingsVogel = v;

        public override string Beschreibung()
        {
            return GetName() + " liebt " +
                _lieblingsVogel.GetName() + " und ist " +
                (GetSteuer() ? "" : "nicht ") + "steuerpflichtig";
        }
    }
}
