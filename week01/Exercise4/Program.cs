using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nNumber Analysis Program");
        Console.WriteLine("=======================\n");
        Console.WriteLine("Enter a list of numbers (positive or negative)");
        Console.WriteLine("Type 0 when finished.\n");

        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out userNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine($"\nThe sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(0).Min();
            if (smallestPositive != 0)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            numbers.Sort();
            Console.WriteLine("\nThe sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"\nAdditional Statistics:");
            Console.WriteLine($"- Count of numbers: {numbers.Count}");
            Console.WriteLine($"- Range: {numbers.Max() - numbers.Min()}");
            Console.WriteLine($"- Median: {CalculateMedian(numbers)}");
        }
        else
        {
            Console.WriteLine("\nNo numbers were entered.");
        }
    }

    static double CalculateMedian(List<int> numbers)
    {
        numbers.Sort();
        int count = numbers.Count;

        if (count % 2 == 0)
        {
            return (numbers[count / 2 - 1] + numbers[count / 2]) / 2.0;
        }
        else
        {
            return numbers[count / 2];
        }
    }
}
