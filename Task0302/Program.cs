using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zeitung z = new Zeitung("WAZ");
            z.Anmelden(new Person("olaf"));
            z.Anmelden(new Person("merkel"));

            z.SendeNachricht("Kleinanzeigen");

            Vermittler v = new Vermittler();
            v.Anmelden(new Person("maus"));
            v.Anmelden(new Person("katz"));

            v.SendeNachricht("Bla");

            Console.ReadLine();
        }
    }
}
