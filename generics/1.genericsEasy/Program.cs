/* 
Exercise 1: Generic Swap Method
Description: Create a generic method called Swap that accepts two parameters of the same type and swaps their values. The method should work for any type, such as integers, strings, or custom objects.
Requirements:
Implement the method using Generics.
Test the method by swapping integers, strings, and custom objects.
 */
namespace Generics
{
    public class Program
    {
        public static void Swap<T>(T a, T b)
        {
            var temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"The first parameter was changed to {a}");
            Console.WriteLine($"The second parameter was changed to {b}");
        }

        public static void Main(string[] args)
        {
            Console.Write("Type the first argument: ");
            var x = Console.ReadLine();
            Console.Write("Type the second argument: ");
            var y = Console.ReadLine();
            Swap(x, y);
            Console.WriteLine($" old values: {x}, {y}");
        }
    }
}


