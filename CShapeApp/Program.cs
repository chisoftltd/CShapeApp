using System;
using System.Linq;

namespace CShapeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine or Write
            Console.WriteLine("Hello World!");
            Console.WriteLine("I will print on a new line.");

            Console.Write("Hello World! ");
            Console.WriteLine("I will print on the same line.");

            //Scientific Numbers
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            //C# User Input
            // Type your username and press enter
            //Console.WriteLine("Enter username:");

            //// Create a string variable and get user input from the keyboard and store it in the variable
            //string userName = Console.ReadLine();

            //// Print the value of the variable (userName), which will display the input value
            //Console.WriteLine("Username is: " + userName);


            //C# Math
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(9.99));

            //String Interpolation
            string firstName = "Ben";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            //Special Characters
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);

            //Short Hand If...Else(Ternary Operator)
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            //System.Linq Namespace
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
            Console.WriteLine(myNumbers.Average()); // returns the average of elements


            //Parameters and Arguments
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");

            //Default Parameter Value
            MyMethod1("Sweden");
            MyMethod1("India");
            MyMethod1();
            MyMethod1("USA");

            //Named Arguments
            MyMethod2("child3");

            //Method Overloading
            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);


            //Multiple Objects
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Car myObj = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj.maxSpeed);

            //Object Methods
            myObj.fullThrottle();  // Call the method

            //Constructors
            Car1 Ford1 = new Car1();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford1.model);  // Print the value of model

            //Constructor Parameters
            Car2 Ford2 = new Car2("Mustang");
            Console.WriteLine(Ford2.model);

            //Automatic Properties
            Person myObj10 = new Person();
            myObj10.Name = "Liam";
            Console.WriteLine(myObj10.Name);
        }

        private static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }

        private static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        private static void MyMethod2(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
        {
            Console.WriteLine(child3);
        }

        private static void MyMethod1(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        private static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }
    }
}
