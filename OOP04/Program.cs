using OOP04.Interfaces;

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
        }
    }
}
