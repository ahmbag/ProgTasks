using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task00
{
    abstract class Shape : IComparable<Shape>
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public int CompareTo(Shape other)
        {
            double thisArea = this.CalculateArea();
            double otherArea = other.CalculateArea();

            if (thisArea != otherArea)
            {
                return thisArea.CompareTo(otherArea);
            }
            else
            {
                return this.CalculatePerimeter().CompareTo(other.CalculatePerimeter());
            }
        }
    }
}
