using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_01
{
    internal class SafeList<T>
    {
        List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                return default(T); // Return default value for the type if index is out of range
            }
            return list[index];
        }
    }
}
