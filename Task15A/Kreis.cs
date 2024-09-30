using System;

namespace Task15A
{
    internal class Kreis
    {
        private double _radius;
        private Punkt _mittelpunkt;

        public Kreis(double radius, Punkt mittelpunkt)
        {
            _radius = radius;
            _mittelpunkt = mittelpunkt;
        }

        public double Umfang()
        {
            return 2 * Math.PI * _radius;
        }

        public double Inhalt()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}