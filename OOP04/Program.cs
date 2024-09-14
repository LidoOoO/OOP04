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
        }
    }
}
