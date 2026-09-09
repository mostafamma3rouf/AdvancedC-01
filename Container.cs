using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_01
{
    internal class Container<T> // generic class <T>
    {
        public T item; // generic field with type T
        public void ADD(T value) // generic parameter with type T
        {
            item = value;
        }

        public T Get() // generic method with type T
        {
            return item;
        }
    }
}
