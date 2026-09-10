using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_01
{
    internal class Student<T> where T : new() // generic class with type parameter and new() constraint
    {
        public T Data; // generic field with type T
        public Student(T data) // generic constructor with type parameter
        {
            Data = data;
        }
    }
}
