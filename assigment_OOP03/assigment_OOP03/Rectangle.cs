using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_OOP03
{
    internal class Rectangle : Irectangle
    {
        public double length { get; set; }
        public double width { get; set; }
        public double Area => length * width;

        public Rectangle(double length, double width)
        {
            length = length;
            width = width;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Rectangle");
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Area: {Area:F2}");
            Console.WriteLine();
        }
    }
}
