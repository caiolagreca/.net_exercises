/* \
Exercise 3: Password Guessing Game (Hard)
Description: Write a program that simulates a password guessing game. The program should store a secret password and repeatedly ask the user to guess the password. If the user guesses the correct password, the program should display a success message and stop. If the guess is wrong, the program should give the user a hint: if the guess is alphabetically greater or smaller than the secret password.
 */
namespace While
{
    public static class Program
    {
        static void guessGame()
        {
            string password = "testing";
            int result = 0;
            do
            {
                Console.WriteLine("Guess the password:");
                string guessWord = Console.ReadLine();
                result = string.Compare(guessWord, password, StringComparison.OrdinalIgnoreCase);
                if (result > 0)
                {
                    Console.WriteLine("Try it again. Hint: Your guess comes after the secret password.");
                }
                else
                {
                    Console.WriteLine("Try it again. Hint: Your guess comes before the secret password.");
                }
            } while (result != 0);
            Console.WriteLine($"You nailed it! The secret password is: {password}");
        }

        static void Main(string[] args)
        {
            guessGame();
        }
    }
}