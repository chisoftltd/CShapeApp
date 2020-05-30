using System;

namespace OPPApp
{
    internal class Pig2 : IAnimal
    {
        public void animalSound2()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    // Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }