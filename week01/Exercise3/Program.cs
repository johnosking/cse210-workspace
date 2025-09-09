using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //string userNumber = Console.ReadLine();
        //int magic = int.Parse(userNumber);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);


        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess < number)
            {
                Console.WriteLine("Guess Higher");
            }

            else if (guess > number)
            {    
                Console.WriteLine("Guess Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }    
        }

    }
}
