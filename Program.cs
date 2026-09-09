namespace AdvancedC_01
{
    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        static void PrintValue<T>(T value) where T : struct
        {
            Console.WriteLine(value);
        }

        static void Show<T>(T value) where T : class
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            /*
             * the type of data is specified when the code is used, not when it is written.
             
             * becouse it: 1. reusable, 2. type safe, 3. better performance, 4. cleaner code.
             */
            #endregion

            #region Q2: Write a generic class Container<T> with Add and Get methods.
            //Container<string> name = new Container<string>();
            //name.ADD("Mostafa");
            //Console.WriteLine(name.Get());
            #endregion

            #region Q3:What are multiple type parameters? Write Pair<TKey, TValue >.
            //Pair<int, string> std = new Pair<int, string>(1, "Mostafa");
            //Console.WriteLine(std.ToString());
            #endregion

            #region Q4: What is a generic method? Write Swap<T> method.
            /*
             * A generic method is a method that works with different data types without writing a separate method for each type
             */
            //int a = 10, b = 6;
            //Swap<int>(ref a, ref b);
            //Console.WriteLine($"a = {a}, b = {b}");
            #endregion

            #region Q5: Write a generic method FindMax<T> that finds maximum value

            //int result = FindMax(10, 6);
            //Console.WriteLine(result);
            #endregion

            #region Q6: What is a generic interface? Write IRepository<T>.
            /*
             * A generic interface is an interface that can work with different data types.
             */

            //IRepository<string> repo;
            #endregion

            #region Q7: What is the 'struct' constraint? Write an example.
            /*
             * The struct constraint means that the generic type must be a value type.
             */

            //PrintValue<int>(10);
            #endregion

            #region Q8: What is the 'class' constraint? Write an example.
            /*
             * The class constraint means that the generic type must be a reference type
             */

            //Show("My name is Mostafa");
            #endregion

            #region Q9: What is the 'new()' constraint? Write an example.
            /*
             * The new() constraint means that the generic type must have a public parameterless
             */

            //Student<int> student = new(1);
            #endregion

            #region Q10: What is the interface constraint? Write an example.
            /*
             * The interface constraint means that the generic type must implement a specific interface.
             */

            //Printer<IPrint> Test = new Printer<IPrint>();
            //Test.PrintItem();
            #endregion

            #region Q11: What is the base class constraint? Write an example.
            /*
             * means that the generic type T must inherit from a specific base class.
             */

            //Cat<string> cat = new Cat<string>();
            //cat.Eat();
            #endregion

            #region Q12: How do you apply multiple constraints? Write an example.
            /*
             * by putting them after where T, separated by commas.
             */

            #endregion

            #region Q13: What does the 'default' keyword do in generics?
            // The default keyword returns the default value of a generic type
            #endregion

            #region Q14: Write a SafeList<T> that returns default when the index is invalid.

            //SafeList<string> safeList = new SafeList<string>();
            //safeList.Add("Mostafa");
            //safeList.Add("Mohamed");
            //safeList.Add("Ma3rouf");

            //Console.WriteLine(safeList.Get(2));
            //Console.WriteLine(safeList.Get(6));
            #endregion

            #region Q15: What is covariance? Explain the 'out' keyword.
            // Covariance means you can use a derived type instead of its base type in a generic interface or delegate.

            // the out keyword is used to specify that a generic type parameter is covariant,
            // meaning it can be used as a return type but not as a parameter type.
            #endregion

            #region Q16: What is contravariance? Explain the 'in' keyword.
            // Contravariance allows a generic type with a base type to be assigned to a generic type with a derived type.

            // the in keyword is used to specify that a generic type parameter is contravariant,
            // meaning it can be used as a parameter type but not as a return type.
            #endregion
        }
    }
}
