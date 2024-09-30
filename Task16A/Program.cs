using System;

namespace Task16A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TennisSpieler ts1 = new TennisSpieler("Hans", 32);
            TennisSpieler ts2 = new TennisSpieler("Müller", 76, ts1);

            int d = ts1.AltersDifferenz(ts2);

            Console.WriteLine("{0} is " + (d<0 ? "jünger" : "älter") +" um {1} Jahre als {2} ", ts1.GetName(), d, ts2.GetName());

            ts1.Ausgabe();
            ts2.Ausgabe();

            Console.WriteLine((ts1.IstLetzter() ? "looser " : "winner ") + "is " + ts1.GetName());
            Console.WriteLine((ts2.IstLetzter() ? "looser " : "winner ") + "is " + ts2.GetName());

            Console.ReadLine();
        }

    }
}