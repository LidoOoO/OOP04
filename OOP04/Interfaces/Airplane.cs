using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces
{
    internal class Airplane : Vehicle, IMovable, IFlyable
    { 

        // Airplane Inherit From Vehicle And Implement Interfaces  (IMovable , IFlyable)

        // Implement Backward Implicitly
        public void Backward()
        {
            Console.WriteLine("Airplane Move Backward");
        }

        //Implement Forward Explicitly 

        void IMovable.Forward()
        {
            Console.WriteLine("Airplane Move Forward On Ground ");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane Move Forward On Air");
        }

        void IMovable.Backward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Backward()
        {
            throw new NotImplementedException();
        }


        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
