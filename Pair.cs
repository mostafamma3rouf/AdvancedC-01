using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_01
{
    internal class Pair<TKey, TValue> // generic class with multiple type
    {
        public TKey Key;  // generic field
        public TValue Value; // generic field

        public Pair(TKey key, TValue value) // generic constructor with multiple type parameters
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return $"Key: {Key}, Value: {Value}";
        }
    }
}
