using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task00
{
    class Ellipse : Shape
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Ellipse(double majorAxis, double minorAxis)
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }

        public override double CalculateArea()
        {
            return Math.PI * MajorAxis * MinorAxis;
        }

        public override double CalculatePerimeter()
        {
            // pi mal 3*summe achsen - wurzel aus (3*große achse + kleine achse) * (große achse + 3*kleine achse)
            return Math.PI * (3 * (MajorAxis + MinorAxis) -
                             Math.Sqrt((3 * MajorAxis + MinorAxis) * (MajorAxis + 3 * MinorAxis)));
        }
    }
}
