using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_01
{
    internal interface IRepository<T> // generic interface with type parameter
    {
        void Add(T item); // generic method
        void Remove(T item); // generic method
    }
}
