﻿using System;

namespace OPPApp
{
    internal class Pig : Animal // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}