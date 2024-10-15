using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0302
{
    internal class Zeitung : INachrichtenQuelle
    {
        string _name;
        public Zeitung(string name)
        {
            _name = name;
        }


        List<INachrichtenEmpfänger> members = new List<INachrichtenEmpfänger>();

        public void Abmelden(INachrichtenEmpfänger empfänger)
        {
            members.Remove(empfänger);
        }

        public void Anmelden(INachrichtenEmpfänger empfänger)
        {
            members.Add(empfänger);
        }

        public void SendeNachricht(string nachricht)
        {
            foreach (var member in members) { 
                member.EmpfangeNachricht("von Zeitung " + _name + " " + nachricht);
            }
        }
    }
}
