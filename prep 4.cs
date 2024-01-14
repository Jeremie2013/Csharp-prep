using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        // Core Requirement: Ask the user for a series of numbers and append them to the list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        do
        {
            Console.Write("Enter number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        // Core Requirement 1: Compute the sum of the numbers in the list
        int sum = numbers.Sum();

        // Core Requirement 2: Compute the average of the numbers in the list
        double average = numbers.Average();

        // Core Requirement 3: Find the maximum number in the list
        int maxNumber = numbers.Max();

        // Display results for Core Requirements
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");

        // Stretch Challenge: Find the smallest positive number and sort the list
        int smallestPositive = numbers.Where(num => num > 0).DefaultIfEmpty(0).Min();
        List<int> sortedList = numbers.OrderBy(num => num).ToList();

        // Display results for Stretch Challenges
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (var num in sortedList)
        {
            Console.WriteLine(num);
        }
    }
}
