using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0305
{
    internal class Sword : IWeapon
    {
        public void Treffer(string gegner)
        {
            Console.WriteLine("Zertrennte {0} genau in der Mitte", gegner); 
        }
    }
}
