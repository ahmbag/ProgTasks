using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Mitarbeiter
    {
        private string _name;
        private string _vorname;
        private int _alter;

        public Mitarbeiter(string name, string vorname, int alter)
        {
            _name = name;
            _vorname = vorname;
            _alter = alter;
        }

        public int GetAlter() => _alter;
        public string GetName() => _vorname + " " + _name;
        public virtual string GetJobName() => "";
        public virtual double GetGehalt() => 0.0;
        public virtual string Ausgabe() => "";
    }
}
