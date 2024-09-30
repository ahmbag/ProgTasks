using System;

namespace Task15A
{
    internal class Vektor
    {
        private Punkt _startpunkt;
        private Punkt _endpunkt;

        public Vektor(Punkt startpunkt, Punkt endpunkt)
        {
            _startpunkt = startpunkt;
            _endpunkt = endpunkt;
        }

        public double Laenge()
        {
            return Math.Sqrt(
                Math.Pow(_startpunkt.GetX() - _endpunkt.GetX(), 2) +
                Math.Pow(_startpunkt.GetY() - _endpunkt.GetY(), 2)
                );
        }
    }
}