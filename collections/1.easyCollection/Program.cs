/* 
Exercise 1: Working with Lists (Easy)
Description: Create a list of integers and add 10 numbers to it. Then, iterate through the list and print each number to the console. After that, remove all even numbers from the list and display the content again.

Requirements:

Use List<int>.
Add elements to the list.
Iterate over the list using a foreach loop.
Remove even numbers and display the updated list.
Tips:

Use the Count property to check the list size.
RemoveAll() is a useful method to remove all even numbers at once.
 */


/* FIRST VERSION */
namespace Collection
{
    class Program
    {
        static void NumbersList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in list)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }
            }
        }
        static void FirstMain(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            NumbersList(list);
        }
    }
}

/* FINAL VERSION */
namespace ColletionFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            NumbersList(list);

        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }

        static void NumbersList(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty.");

            }

            PrintList(list);
            Console.WriteLine();
            list.RemoveAll(item => item % 2 == 0);
            PrintList(list);
        }
    }
}