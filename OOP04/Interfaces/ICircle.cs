using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces
{
    //Create two interfaces, ICircle and IRectangle , that inherit from IShape.
    internal interface ICircle : IShape
    {
        double Radius { get; set; }
 
    }
}
