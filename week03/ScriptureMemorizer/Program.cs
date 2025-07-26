using System;

class Program
{
    static void Main(string[] args)
    {
        // sample scripture (John 3:16)
        Reference reference = new Reference("John", 1, 1);
        Scripture scripture = new Scripture(reference, "in the beginning was the word, and the word was with God, and the word was God. and the word became man.");

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            scripture.HideRandomWords(3);
        }
    }
}
