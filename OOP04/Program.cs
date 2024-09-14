using OOP04.Interfaces;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 Interface

            //IMyType myType = new IMyType(); //Invalid
            //You Can not Create an object from interface but you can create a reference from interface
            //IMyType myType; 
            //You Can Create a Reference From Interface
            //CLR Will Allocate 4 Bytes For Reference "MyType"
            //Reference "MyType" Refer To Null
            //Reference "MyType" Can Refer To An Object From Class Or Struct Implement Interface 

            //myType.Id = 20;  // Invalid -> myType Refer to Null
            //myType.MyFun(1); // Invalid -> myType Refer to Null
            //myType.Print();  // Invalid -> myType Refer to Null



            //MyType myType1 = new MyType();
            //myType1.Id = 30;
            //myType1.MyFun(100);
            //myType1.Print(); //Invalid -> Default Implemented Method

            IMyType myType = new MyType();

            //Ref From Interface -> Object From Class Implement Interface
            myType.Id = 30;
            myType.MyFun(600); // Hello Route : X = 600 , ID = 30
            myType.Print();    // Hello Defult Implemented Method From Interface

            #endregion
        }
    }
}
