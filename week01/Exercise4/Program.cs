using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumbers = -1;

        while (userNumbers != 0)
        {
            Console.Write("Enter a number (enter 0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumbers = int.Parse(userResponse);

            if (userNumbers != 0)
            {
                numbers.Add(userNumbers);
            }

        }
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of numbers is {sum}");
    }
}