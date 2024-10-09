using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0208
{
    internal class Vogel : Haustier
    {
        bool _singvogel;

        public Vogel(string name, double kosten, bool singvogel) : base(name, false, kosten)
        {
            _singvogel = singvogel;
        }

        public bool GetSing() => _singvogel;

        public override string Beschreibung()
        {
            return GetName() + " ist " +
                (_singvogel ? "ein " : "kein") + " Singvogel und ist " +
                (GetSteuer() ? "" : "nicht ") + "steuerpflichtig";
        }
    }
}
