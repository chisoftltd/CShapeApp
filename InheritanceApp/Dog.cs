using System;

namespace OPPApp
{
    internal class Dog : Animal // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}