using OOP04.Classes;
using OOP04.Enum;
using OOP04.Interfaces;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region Part 01

            //Q1
            #region What is the primary purpose of an interface in C#?

            //b) To define a blueprint for a class

            #endregion

            //Q2
            #region Which of the following is NOT a valid access modifier for interface members in C#?

            //d) public

            #endregion

            //Q3
            #region Can an interface contain fields in C#?

            //b) No

            #endregion

            //Q4
            #region In C#, can an interface inherit from another interface?

            //b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            //Q5
            #region Which keyword is used to implement an interface in a class in C#?

            //d) implements

            #endregion

            //Q6
            #region Can an interface contain static methods in C#?

            //a) Yes

            #endregion

            //Q7
            #region In C#, can an interface have explicit access modifiers for its members?

            //b) No, all members are implicitly public

            #endregion

            //Q8
            #region What is the purpose of an explicit interface implementation in C#?

            //b) To provide a clear separation between interface and class members

            #endregion

            //Q9
            #region In C#, can an interface have a constructor?

            //b) No, interfaces cannot have constructors

            #endregion

            //Q10
            #region How can a C# class implement multiple interfaces?

            //c) By separating interface names with commas

            #endregion


            #endregion

            #region Part 02

            #region Q1

            //Console.WriteLine("Q1\n===");

            //ICircle shape01 = new Circle(314.2, 10.1);

            //IRectangle shape02 = new Rectangle(5, 10, 50);


            //shape01.DisplayShapeInfo();
            //shape02.DisplayShapeInfo();

            //Console.WriteLine("===================================\n===================================");
            #endregion


            #region Q2

            IAuthenticationService authentication = new BasicAuthenticationService();

            #region AuthenticateUser

            //Console.WriteLine(authentication.AuthenticateUser("Waleed", "33rhw8a3")); // True

            //Console.WriteLine(authentication.AuthenticateUser("ALaaa", "efsfsada")); // False


            #endregion


            #region AuthorizeUser

            //Console.WriteLine(authentication.AuthorizeUser("Waleed" , Role.AdmisAdministrator)); // True


            //Console.WriteLine(authentication.AuthorizeUser("Mohamed" , Role.User)); // False


            #endregion



            #endregion


            #region Q3

            INotificationService notification01 = new EmailNotificationService();

            INotificationService notification02 = new SmsNotificationService();
            
            INotificationService notification03 = new PushNotificationService();


            notification01.SendNotification("waleedmahmoud43gmail.com", "Sent From Email");

            Console.WriteLine("==================================");

            notification02.SendNotification("01111111165", "Sent From SMS");

            Console.WriteLine("==================================");

            notification03.SendNotification("PushNotification", "Sent By PushNotification");

            #endregion



            #endregion



        }
    }
}
