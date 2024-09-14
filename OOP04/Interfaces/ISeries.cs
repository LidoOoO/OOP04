using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces
{
    // Developer 01
    internal interface ISeries
    {
        public int Current { get; set; }

        public void GetNext();


        public void Reset()
        {
            Current = 0;
        }
    }
}
