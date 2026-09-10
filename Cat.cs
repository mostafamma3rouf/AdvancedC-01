using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_01
{
    internal class Cat<T> : Animal, IMovable // Generic class with type parameter : Base class, Interface => multiple constraints
    {
        public void Move()
        {
            Console.WriteLine("Cat is moving");
        }
    }
}
