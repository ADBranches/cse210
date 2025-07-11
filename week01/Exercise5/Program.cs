using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

        Console.WriteLine("\nThank you for using our program!");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("\nWelcome to the Program!");
        Console.WriteLine("-----------------------\n");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Name cannot be empty. Please enter your name: ");
            name = Console.ReadLine();
        }

        return name.Trim();
    }

    static int PromptUserNumber()
    {
        int number;
        Console.Write("Please enter your favorite number: ");

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Please enter an integer: ");
        }

        return number;
    }

    static int SquareNumber(int number)
    {
        return checked(number * number);
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"\n{name}, the square of your number is {squaredNumber:N0}");
        Console.WriteLine($"Math verification: {Math.Pow((int)Math.Sqrt(squaredNumber), 2)}");
    }
}
