using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0305
{
    internal class Ninja
    {
        IWeapon weapon;
        string name;

        public Ninja(IWeapon weapon, string name)
        {
            this.weapon = weapon;
            this.name = name;
        }   

        public void Attack(string opponent)
        {
            weapon.Treffer(opponent);
        }
    }
}
