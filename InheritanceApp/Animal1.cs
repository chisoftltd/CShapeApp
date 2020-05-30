using System;

namespace OPPApp
{
    // Abstract class
    abstract class Animal1
    {
        // Abstract method (does not have a body)
        public abstract void animalSound1();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}