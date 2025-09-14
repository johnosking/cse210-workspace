using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }    
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please, enter your name : ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please, enter your favourite number : ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Hello {name}, the square of your favourite number is {square}");
    }
}