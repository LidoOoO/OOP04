using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces
{
    //Default Access Modifier of Interface => Internal
    //Developer 01
    internal interface IMyType
    {
        //Default Access Modifier Inside Interface => Public
        //Private Access Modifier is not allowed inside interface
        // What You Can Write Inside The Interface
        // 1. Signature for Property [Name - Type - [Get] | [Set]]
        public int Id { get; set; }
        // Inside Class Or Struct -> Automatic Property
        // Compiler Will Generate Private Hiddin Attribute [Backing Field] 

        // Inside Interface -> Signature For Property




        // 2. Signature for Method [Name - Return Type - Parametars]
        public void MyFun(int X);
        // 3. Default Implemented Method [C# 8.0 Feature (.Net Core 3.1 2019)]
        public void Print()
        {
            Console.WriteLine("Hello Defult Implemented Method From Interface");
        }

    }
}
