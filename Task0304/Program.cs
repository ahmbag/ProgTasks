using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task0304
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wasserstand wS = new Wasserstand();

            BüffelBeobachter b = new BüffelBeobachter();
            StraßeBeobachter s = new StraßeBeobachter();
            WanderBeobachter w = new WanderBeobachter();

            wS.AddBeobachter(b);
            wS.AddBeobachter(s);
            wS.AddBeobachter(w);

            wS.SetWasserstand(0.5);

            Random r = new Random();

            for (int i = 0; i < 20; i++) {
                wS.SetWasserstand(r.Next(0, 1000) * 0.01);
                wS.BenachrichtigeBeobachter();
                Thread.Sleep(500);
            }

            Console.ReadLine();
        }
    }
}
