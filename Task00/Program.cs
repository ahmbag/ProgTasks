using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of shapes
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(10, 5),
                new Square(7),
                new Circle(4),
                new Ellipse(3, 4)
            };

            // Sort shapes by area and perimeter
            shapes.Sort();

            // Display sorted shapes
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.GetType().Name}, " +
                    $"Area: {shape.CalculateArea():F2}, " +
                    $"Perimeter: {shape.CalculatePerimeter():F2}");
            }

            Console.ReadLine();
        }
    }
}
