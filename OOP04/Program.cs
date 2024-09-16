using OOP04.Interfaces;
using OOP04.Interfaces.ICloneable_Interface;
using System.Text;

namespace OOP04
{
    internal class Program
    {
        public static void Print10NumbersFromSeries(ISeries series)
        {
            if(series is not null)
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.Write($" {series.Current} "); // 0
                    series.GetNext();
                }
                series.Reset();
            }
        }
        
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

            //IMyType myType = new MyType();

            ////Ref From Interface -> Object From Class Implement Interface
            //myType.Id = 30;
            //myType.MyFun(600); // Hello Route : X = 600 , ID = 30
            //myType.Print();    // Hello Defult Implemented Method From Interface

            #endregion

            #region Part 02 Interface [Example 01]

            //SeriesByTwo seriesByTwo = new SeriesByTwo();

            //Print10NumbersFromSeries(seriesByTwo);
            //// 0  2  4  6  8  10  12  14  16  18

            //Console.WriteLine("\n ==================================");

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);
            //// 0  3  6  9  12  15  18  21  24  27

            //Console.WriteLine("\n ==================================");

            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10NumbersFromSeries(seriesByFour);
            //// 0  4  8  12  16  20  24  28  32  36
            #endregion

            #region Part 03 Implment Interface (Implicitly Vs Explicitly)

            //Car car = new Car();
            //car.Backward();
            ////Car Move Backward On Ground

            //Airplane airplane = new Airplane();
            //airplane.Backward();
            ////Airplane Move Backward
            ////airplane.Forward(); // Invalid

            //IMovable MovablePlan = new Airplane();
            //MovablePlan.Forward(); // Airplane Move Forward On Ground 

            //IFlyable FlyablePlane = new Airplane();
            //FlyablePlane.Forward();

            #endregion

            #region Part 04 Deep Copy Vs Shallow Copy [Array Of Value Type]

            //int[] Arr01 = { 1, 5, 7 };
            //int[] Arr02 = new int[3]; // {0 , 0 , 0}

            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}"); //HC Of Arr01 = 54267293
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}"); //HC Of Arr02 = 18643596

            #region Shallow Copy [Stack]

            //Arr02 = Arr01; // Shallow Copy [سطحي]
            //               // Copy Occurred At stack
            //               // Reference [Arr01 , Arr02] => same Object


            //Console.WriteLine("Aftre Shallow Copy");

            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}"); //HC Of Arr01 = 54267293
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}"); //HC Of Arr02 = 18643596

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr02[0] = 100;

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            #endregion

            #region Deep Copy [Heap]

            //Arr02 = (int[]) Arr01.Clone();
            ///// Clone => Deep Copy 
            ///// Deep Copy Occurred At Heap
            ///// Create New Object With Different And New Identity
            /////That Object Will be The Same Object State [Data] Of Caller [Arr01]
            /////Return To An Object


            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}"); //HC Of Arr01 = 54267293
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}"); //HC Of Arr02 = 18643596

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); // 1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); // 1

            //Arr01[0] = 100;

            //Console.WriteLine("after arr01[0] = 100");
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); // 1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); // 1

            #endregion

            #endregion

            #region Part 05 Deep Copy Vs Shallow Copy [Array Of Reference Type (String)]

            #region Array Of String [Immutable Type]

            //string[] Names01 = { "Omar" };
            //string[] Names02 = new string[1]; // {null}


            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}"); // HC Of Names01 = 54267293
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}"); // HC Of Names02 = 18643596

            #region shallow Copy

            //Names02 = Names01; // Shallow Copy [Reference --- Stack]
            //                   // Reference [Names01 - Names02] => Same Object

            //Console.WriteLine("After Shallow Copy ");

            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}"); // HC Of Names01 = 54267293
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}"); // HC Of Names02 = 54267293


            //Console.WriteLine($"Names01[0] = {Names01[0]}"); // Omar 
            //Console.WriteLine($"Names02[0] = {Names02[0]}"); // Omar 


            //Names02[0] = "Aya";

            //Console.WriteLine($"Names01[0] = {Names01[0]}"); // Aya 
            //Console.WriteLine($"Names02[0] = {Names02[0]}"); // Aya 

            #endregion

            #region Deep Copy 
            //Names02 = (string[]) Names01.Clone();
            //// Clone => DEEP COPY
            //// Create New Object With New And Different Identity
            //// Object Will Have Same Object State [Data] Of Caller Names01


            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}"); // HC Of Names01 = 54267293
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}"); // HC Of Names02 = 33574638


            //Console.WriteLine($"Name01[0] = {Names01[0]}"); // Omar
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); // Omar

            //Names02[0] = "Aya";

            //Console.WriteLine($"Name01[0] = {Names01[0]}"); // Omar
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); // Aya


            #endregion


            #endregion

            #endregion

            #region Part 06 Deep Copy Vs Shallow Copy [Array Of Reference Type (StringBuilder)]

            //StringBuilder[] Names01 = new StringBuilder[1];
            ////Names01[0].Append("Waleed"); //NullReferenceException
            //Names01[0] = new StringBuilder("Waleed");

            //StringBuilder[] Names02 = new StringBuilder[1];

            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}"); // HC Of Names01 = 54267293
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}"); // HC Of Names02 = 18643596

            #region Shallow Copy [Stack]

            //Names02 = Names01; //Shallwo Copy [Stack]

            //// 2 References [Names01 , Names02] => Same Object

            //Console.WriteLine("Names02 = Names01");

            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}"); // HC Of Names01 = 54267293
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}"); // HC Of Names02 = 54267293

            //Console.WriteLine($"Name01[0] = {Names01[0]}"); // Waleed
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); // Waleed


            //Names02[0].Append(" Amr ");
            //Console.WriteLine("Names02[0].Append(\"Amr\");");

            //Console.WriteLine($"Name01[0] = {Names01[0]}"); // Waleed Amr 
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); // Waleed Amr  
            #endregion

            #region Deep Copy [Heap]

            //Names02 = (StringBuilder[]) Names01.Clone(); //Deep Copy 
            //                                             // 2 Reference [Names01 , Names02] => 2 Different Objects


            //Console.WriteLine("Names02 = (StringBuilder[]) Names01.Clone()");

            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}"); // HC Of Names01 = 54267293
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}"); // HC Of Names02 = 54267293

            //Console.WriteLine($"Name01[0] = {Names01[0]}"); // Waleed
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); // Waleed


            //Names02[0].Append(" Amr ");
            //Console.WriteLine("Names02[0].Append(\"Amr\");");

            //Console.WriteLine($"Name01[0] = {Names01[0]}"); // Waleed Amr 
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); // Waleed Amr  

            #endregion




            #endregion

            #region Part 07 Built-in Interfaces - ICloneable

            #region Shallow Copy And Deep Copy For UserDefiend Datatype

            //Employee employee01 = new Employee() { Id = 10, Name = "Aliaa", Salary = 9000 };

            //Employee employee02 = new Employee() { Id = 20, Name = "Mona", Salary = 10000 };

            ////Employee employee01 = new Employee() { Id = 10, Name = new StringBuilder("Aliaa"), Salary = 9000 };

            ////Employee employee02 = new Employee() { Id = 20, Name = new StringBuilder("Mona"), Salary = 10000 };

            //Console.WriteLine($"HashCode Of Employee01 = {employee01.GetHashCode()} ");
            //Console.WriteLine($"Employee01 = {employee01}");
            //// HashCode Of Employee01 = 54267293
            //// Employee01 = Id = 10 , Name = Aliaa , Salary = $9,000.00


            //Console.WriteLine($"HashCode Of Employee02 = {employee02.GetHashCode()} ");
            //Console.WriteLine($"Employee02 = {employee02}");
            //// HashCode Of Employee02 = 18643596
            //// Employee02 = Id = 20 , Name = Mona , Salary = $10,000.00

            #endregion

            #region Shallow Copy And Deep Copy

            #region Shallow Copy [Stack]

            //employee02 = employee01; // Shallow Copy 

            //// 2 References [Employee01 ,Employee02] => Same Objcet
            //// { Id = 10 , Name = "Aliaa" , Salary = 9000 } ==> Has 2 References
            //// { Id = 20 , Name = "Mona" , Salary = 10000 } ==> Unreachable Objcet

            //Console.WriteLine("After Shallow Copy ");

            //Console.WriteLine($"HashCode Of Employee01 = {employee01.GetHashCode()} ");
            //Console.WriteLine($"Employee01 = {employee01}");
            //// HashCode Of Employee01 = 54267293
            //// Employee01 = Id = 10 , Name = Aliaa , Salary = $9,000.00


            //Console.WriteLine($"HashCode Of Employee02 = {employee02.GetHashCode()} ");
            //Console.WriteLine($"Employee02 = {employee02}");

            //// Employee02 => Id = 20 , Name = 145236951  , Salary = 10000
            //// 145236951 => Mona

            //employee01.Id = 100;
            //employee01.Name = "Aya";
            //employee01.Salary = 20000;


            //Console.WriteLine("================= After Changing Employee01 Values ==================");
            //Console.WriteLine($"Employee01 = {employee01}");
            //Console.WriteLine($"Employee02 = {employee02}");

            #endregion

            #region Shallow Copy - Name Is String Builder

            //employee02 = employee01; // Shallow Copy 

            //// 2 References [Employee01 ,Employee02] => Same Objcet
            //// { Id = 10 , Name = "Aliaa" , Salary = 9000 } ==> Has 2 References
            //// { Id = 20 , Name = "Mona" , Salary = 10000 } ==> Unreachable Objcet

            //Console.WriteLine("After Shallow Copy ");

            //Console.WriteLine($"HashCode Of Employee01 = {employee01.GetHashCode()} ");
            //Console.WriteLine($"Employee01 = {employee01}");
            //// HashCode Of Employee01 = 54267293
            //// Employee01 = Id = 10 , Name = Aliaa , Salary = $9,000.00


            //Console.WriteLine($"HashCode Of Employee02 = {employee02.GetHashCode()} ");
            //Console.WriteLine($"Employee02 = {employee02}");

            //// Employee02 => Id = 20 , Name = 145236951  , Salary = 20000 
            //// 145236951 => Aliaa Omar

            //employee01.Id = 100;
            //employee01.Name.Append(" Omar");    
            //employee01.Salary = 20000;


            //Console.WriteLine("================= After Changing Employee01 Values ==================");
            //Console.WriteLine($"Employee01 = {employee01}");
            //Console.WriteLine($"Employee02 = {employee02}");



            #endregion


            #region Deep Copy - Name Is String 

            //employee02 = (Employee) employee01.Clone();

            //// Create New Objcet With And Different Identity
            //// Object Has Same Object State Of Caller


            //Console.WriteLine("After Deep Copy ");


            //Console.WriteLine($"HashCode Of Employee01 = {employee01.GetHashCode()} ");
            //Console.WriteLine($"Employee01 = {employee01}");
            //// HashCode Of Employee01 = 54267293
            //// Employee01 = Id = 10 , Name = Aliaa , Salary = $9,000.00


            //Console.WriteLine($"HashCode Of Employee02 = {employee02.GetHashCode()} ");
            //Console.WriteLine($"Employee02 = {employee02}");
            //// HashCode Of Employee02 = 33574638
            //// Employee02 = Id = 20 , Name = Mona , Salary = $10,000.00

            //// Employee02 = Id = 200 , Name = 65479896 , Salary = $30,000.00 
            //// 12345687 = "Aliaa"
            //// 65479896 = "Mona" 


            //employee02.Id = 200;
            //employee02.Name = "Mona";
            //employee02.Salary = 30000;

            //Console.WriteLine("After Changing Employee02 Values");
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);

            #endregion

            #region Deep Copy - Name Is StringBuilder

            //employee02 = (Employee) employee01.Clone();

            //Console.WriteLine("After Deep Copy ");

            //Console.WriteLine($"HashCode Of Employee01 = {employee01.GetHashCode()} ");
            //Console.WriteLine($"Employee01 = {employee01}");
            //// HashCode Of Employee01 = 54267293
            //// Employee01 = Id = 10 , Name = 123456789 , Salary = $9,000.00


            //Console.WriteLine($"HashCode Of Employee02 = {employee02.GetHashCode()} ");
            //Console.WriteLine($"Employee02 = {employee02}");
            //// HashCode Of Employee02 = 18643596
            //// Employee02 = Id = 20 , Name = Mona , Salary = $10,000.00



            //// Employee02 : Id = 500 , Name = 123456789 , Salary = $6,000.00            
            //// 123456789 = "Aliaa Tarek"
            //employee02.Id = 500;
            //employee02.Name.Append(" Tarek");
            //employee02.Salary = 6000;


            //Console.WriteLine("After Changing Employee02 Values");
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);

            #endregion


            //// We Have 2 Ways Deep Copy  User Defiend Datatype
            //// 1. Clone
            //// 2. Copy Constructor


            //employee02 = new Employee(employee01);


            //Console.WriteLine("After Deep Copy");


            //Console.WriteLine($"HashCode Of Employee01 = {employee01.GetHashCode()} ");
            //Console.WriteLine($"Employee01 = {employee01}");
            //// HashCode Of Employee01 = 54267293
            //// Employee01 = Id = 10 , Name = Aliaa , Salary = $9,000.00


            //Console.WriteLine($"HashCode Of Employee02 = {employee02.GetHashCode()} ");
            //Console.WriteLine($"Employee02 = {employee02}");
            //// HashCode Of Employee02 = 18643596
            //// Employee02 = Id = 20 , Name = Mona , Salary = $10,000.00

            #endregion



            #endregion

            #region Part 08 Built-In Interface ICompareable

            //int[] Numbers = { 8, 7, 4, 9, 6, 1, 2, 5, 3, 10 };


            //Array.Sort(Numbers);

            //foreach(int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //Employee[] employees = new Employee[4]
            //{
            //    new Employee(){Id = 10 , Name = "Aliaa" , Salary = 1000 },
            //    new Employee(){Id = 20 , Name = "Mona" , Salary = 20000 },
            //    new Employee(){Id = 30 , Name = "Ali" , Salary = 9000 },
            //    new Employee(){Id = 40 , Name = "Aya" , Salary = 6000 }
            //};

            //Array.Sort(employees);

            //// System.InvalidOperationException
            //// At least one object must implement IComparable.
            

            ////foreach (Employee employee in employees)
            ////{
            ////    Console.WriteLine(employee);


            ////    //Id = 10 , Name = Aliaa , Salary = $1,000.00
            ////    //Id = 40 , Name = Aya , Salary = $6,000.00
            ////    //Id = 30 , Name = Ali , Salary = $9,000.00
            ////    //Id = 20 , Name = Mona , Salary = $20,000.00
            ////}


            #endregion
        }
    }
}
