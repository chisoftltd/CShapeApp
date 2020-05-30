using System;

namespace CShapeApp
{
    class Car
    {
        public string color = "red";     
        public int maxSpeed = 200;

        public string Name { get; internal set; }

        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
}
