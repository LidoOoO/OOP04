using OOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Classes
{
    internal class Rectangle : IRectangle
    {

        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }

        public Rectangle(double width, double height, double area)
        {
            Width = width;
            Height = height;
            Area = area;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This Shape Is Rectangle : Width = {Width} , Height = {Height} , Area = {Area}");
        }
    }
}
