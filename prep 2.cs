using System;

class Program
{
    static void Main()
    {
        // Core Requirement 1: Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = Convert.ToInt32(Console.ReadLine());

        // Core Requirement 2: Determine the letter grade and check if passed
        string letter = ""; // Variable to store the letter grade

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Check if passed and display appropriate message
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course with a grade of " + letter + ".");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Better luck next time!");
        }

        // Core Requirement 3: Display the letter grade
        Console.WriteLine("Your letter grade is: " + letter);

        // Stretch Challenge: Determine the sign (+ or -) for the grade
        string sign = ""; // Variable to store the sign

        if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (gradePercentage % 10 < 3)
        {
            sign = "-";
        }

        // Additional logic for exceptional cases
        if (letter == "A" && gradePercentage % 10 >= 7)
        {
            sign = ""; // No A+
        }
        else if (letter == "F")
        {
            sign = ""; // No F+
        }

        // Display the final grade with sign
        Console.WriteLine("Your final grade is: " + letter + sign);
    }
}
