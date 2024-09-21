using OOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Classes
{
    internal class Circle : ICircle
    {

        public double Area { get; set; }

        public double Radius { get; set; }

        public Circle(double area, double radius)
        {
            Area = area;
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This Shape Is Circle : Radius = {Radius} , Area = {Area}");
        }
    }
}
