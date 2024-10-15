using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0305
{
    internal class Shuriken : IWeapon
    {
        public void Treffer(string gegner)
        {
            Console.WriteLine("Traf {0} mit voller Wucht", gegner);
        }
    }
}
