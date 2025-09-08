using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userinput = Console.ReadLine();

        int gradePercentage = int.Parse(userinput);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your grade is A");
    
        }

        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your grade is B");

        }
        
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your grade is C");
        }

        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your grade is D");
        }

        else
        {
            Console.WriteLine("Your grade is F");
        }
    }    
}