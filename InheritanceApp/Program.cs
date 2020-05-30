using System;

namespace OPPApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            Pig1 myPig1 = new Pig1(); // Create a Pig object
            myPig1.animalSound1();  // Call the abstract method
            myPig1.sleep();  // Call the regular method


            Pig2 myPig2 = new Pig2();  // Create a Pig object
            myPig2.animalSound2();


            Level myVar = Level.Medium;
            Console.WriteLine(myVar);


            int myNum = (int)Months.April;
            Console.WriteLine(myNum);
        }

        enum Level
        {
            Low,
            Medium,
            High
        }


        enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6
        }
    }
}
