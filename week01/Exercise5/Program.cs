using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = AskUserName();
        int userNumber = AskUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string AskUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int AskUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Hello {name}, the square of your favorite number is {square}");
    }
}