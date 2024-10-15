using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0303
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatur t = new Temperatur();
            t.Kelvin = 283.15;
            Console.WriteLine(t.ToString());

            Temperatur t2 = new Temperatur();
            t2.Fahrenheit = 50;
            Console.WriteLine(t2.ToString());

            Temperatur t3 = new Temperatur();
            t3.Celsius = 10;
            Console.WriteLine(t3.ToString());

            Console.ReadLine();
        }
    }
}
