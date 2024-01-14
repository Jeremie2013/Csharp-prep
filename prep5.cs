using System;

class Program
{
    static void Main()
    {
        // Call DisplayWelcome function
        DisplayWelcome();

        // Call PromptUserName function to get the user's name
        string userName = PromptUserName();

        // Call PromptUserNumber function to get the user's favorite number
        int userNumber = PromptUserNumber();

        // Call SquareNumber function to square the user's number
        int squaredNumber = SquareNumber(userNumber);

        // Call DisplayResult function to display the final result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // Function to square a given number and return the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the final result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
