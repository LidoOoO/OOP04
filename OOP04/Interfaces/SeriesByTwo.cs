using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces
{
    //Developer 02
    internal class SeriesByTwo : ISeries
    {
        public int Current { get ; set ; }

        public void GetNext()
        {
            Current += 2;
        }


    }
}
