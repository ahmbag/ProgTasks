using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Redeemer r = new Redeemer();
            Sword s = new Sword();
            Shuriken sh = new Shuriken();

            Ninja n1 = new Ninja(r, "killer");
            Ninja n2 = new Ninja(s, "lethal");
            Ninja n3 = new Ninja(sh, "chuck norris");

            n1.Attack("peppa pig");
            n2.Attack("Batman");
            n3.Attack("Oma");

            Console.ReadLine();
        }
    }
}
