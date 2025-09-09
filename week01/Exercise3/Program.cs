using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string userNumber = Console.ReadLine();
        int magic = int.Parse(userNumber);
    


        int guess = -1;

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess < magic)
            {
                Console.WriteLine("Guess Higher");
            }

            else if (guess > magic)
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
