using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0305
{
    internal class Redeemer : IWeapon
    {
        public void Treffer(string gegner)
        {
            Console.WriteLine("Pulverisiert {0} und alles was im 1km Umkreis stand", gegner);
        }
    }
}
