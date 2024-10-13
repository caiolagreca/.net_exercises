/* Exercício 1: Counting Even Numbers
Escreva um programa que conte e exiba a quantidade de números pares entre 1 e 100. Utilize um loop while para iterar pelos números e uma estrutura if-else para verificar a paridade de cada número. */

namespace While
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numbers = 99;
            object[] result = CountNumbers(numbers);
            Console.WriteLine($"Total even numbers = {result[0]}");
            Console.WriteLine($"Total odd numbers = {result[1]}");
            Console.WriteLine("");
            Console.WriteLine($"List of even numbers = {string.Join(", ", (List<int>)result[2])}");
            Console.WriteLine($"List of odd numbers = {string.Join(", ", (List<int>)result[3])}");
        }

    public static object[] CountNumbers(int numbers)
        {
            int counter = 1;
            int even = 0;
            List<int> evenList = [];
            int odd = 0;
            List<int> oddList = [];
            while (counter <= numbers)
            {
                if (counter % 2 == 0)
                {
                    even += 1;
                    evenList.Add(counter);
                }
                else
                {
                    odd += 1;
                    oddList.Add(counter);
                }
                counter++;
            }
            return [even, odd, evenList, oddList];
        }
    }
}
