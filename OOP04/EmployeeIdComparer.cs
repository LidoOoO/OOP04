using OOP04.Interfaces.ICloneable_Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class EmployeeIdComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {

            Employee? EmpX = (Employee) x;
            Employee? EmpY = (Employee) y;
            // EmpX.Id > EmpY.Id          => +Ve
            // EmpX.Id < EmpY.Id          => -Ve
            // EmpX.Id = EmpY.Id          => 0
            // EmpX = null                => +Ve
            // EmpY = null                => -Ve
            // EmpX = null & EmpY = null  => 0
            return EmpX?.Id.CompareTo(EmpY?.Id) ?? (EmpY is null ? 0 : -1);
        }
    }
}
