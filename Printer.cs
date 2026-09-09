using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_01
{
    internal class Printer<T> where T : IPrint // generic class with type parameter and interface constraint
    {
        public void PrintItem(T item) // generic method with type parameter
        {
            item.Print(); // call the Print method of the IPrint interface
        }
    }
}
