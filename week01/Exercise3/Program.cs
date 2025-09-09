using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string userNumber = Console.ReadLine();
        int magic = int.Parse(userNumber);
    
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        if (guess < magic)
        {
            Console.Write("Guess Higher");
        }
        else if (guess == magic)
        {
            Console.Write("You guessed it");
        }
        else
        {    
            Console.Write("Guess Lower");
        }


    }
}
