/* 
Exercise 3: Generic Constraints (Hard)
Description: Create a method that accepts a list of any type (using Generics) and returns the maximum value in that list. The method should have a generic constraint, ensuring that the type implements IComparable<T>, so it can be compared.

Requirements:

Use generic constraints to ensure that the type can be compared.
Implement a method FindMax<T>(List<T> list) that returns the maximum value from the list.
Test with different types like int, double, and custom objects that implement IComparable<T>.
 */

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<double> list = [1.1, 2.3, 1.4, 0.6, 2];
            var result = GetMax(list);
            Console.WriteLine(result);
        }

        public static T GetMax<T>(List<T> list) where T : IComparable<T>
        {
            if (list == null || list.Count == 0) throw new ArgumentNullException("Empty List");

            T maxValue = list[0];
            foreach (T item in list)
            {
                if (item.CompareTo(maxValue) > 0)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }

    }

}