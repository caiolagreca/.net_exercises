/* Exercise 2: Sum of Positive Numbers (Medium)
Description: Write a program that asks the user to input numbers. The program should continue asking for numbers until the user enters a negative number. Once a negative number is entered, the program should stop and print the sum of all the positive numbers entered. */

namespace While
{
    public static class Program
    {
        static int SumPositiveNumber()
        {
            int sumNumbers = 0;
            while (true)
            {
                Console.WriteLine("Insert a number:");
                string inputNumber = Console.ReadLine();
                bool result = int.TryParse(inputNumber, out int number);
                
                if (result)
                {
                    if (number > 0)
                    {
                        sumNumbers += number;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Insert a valid number");
                }
            }
            return sumNumbers;
        }

        static void Main(string[] args)
        {
            int sum = SumPositiveNumber();
            Console.WriteLine($"The sum of all positive numbers is: {sum}");

        }
    }
}
