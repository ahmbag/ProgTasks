using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            Auto a2 = new Auto(7, "OB BO 5");

            Pickup p1 = new Pickup(1000);
            Pickup p2 = new Pickup(2000, "DU UD 7");

            a1.Fahre(5);
            a2.Fahre(10);
            p1.Fahre(20);
            p2.Fahre(40);

            a1.AntenneAusfahren();
            a1.Waschen();

            p1.Beladen(500);
            p1.AntenneAusfahren();
            p1.Waschen();

            Console.ReadLine();
        }
    }
}
