using System;

namespace OPPApp
{
    internal class Dog : Animal // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}