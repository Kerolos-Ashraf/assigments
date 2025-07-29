using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_OOP03
{
    internal class Circle : Icircle

    {
        public double radius { get ; set; }
        public double Area => Math.PI * radius * radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Circle");
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {Area:F2}");
            Console.WriteLine();
        }
    }
}
