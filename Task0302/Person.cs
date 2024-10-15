using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0302
{
    internal class Person : INachrichtenEmpfänger
    {
        string _name;

        public Person(string name)
        {
            _name = name;
        }   

        public void EmpfangeNachricht(string nachricht)
        {
            Console.WriteLine("Breaking news an "+ _name +" :"  + nachricht);
        }
    }
}
