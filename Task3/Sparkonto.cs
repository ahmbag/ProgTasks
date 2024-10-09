using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Sparkonto : Konto
    {
        public Sparkonto(string name, string vorname, int kontonummer, double habenszinssatz = 0.5) : base(name, vorname, kontonummer, habenszinssatz)
        {
        }
    }
}
