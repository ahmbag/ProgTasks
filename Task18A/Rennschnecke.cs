using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18A
{
    internal class Rennschnecke
    {
        private string _name;
        private int _maxspeed;
        private int _distance;
        static Random r = new Random();

        public Rennschnecke(string name, int maxspeed, int distance = 0)
        {
            _name = name;
            _maxspeed = maxspeed;
            _distance = distance;
        }

        public string GetName() { return _name; }
        public int GetDistance() { return _distance; }

        public void Krieche()
        {          
            _distance += r.Next(0, _maxspeed);
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        override public string ToString()
        {
            return ("Name: "+_name+" Maxspeed: "+_maxspeed+" Strecke: " + _distance);
        }

        internal int GetSpeed()
        {
            return _maxspeed;
        }
    }
}
