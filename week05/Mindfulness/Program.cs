using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program Menu");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflecting Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an activity (1-4): ");

                switch (Console.ReadLine())
                {
                    case "1":
                        new BreathingActivity().Run();
                        break;
                    case "2":
                        new ReflectingActivity().Run();
                        break;
                    case "3":
                        new ListingActivity().Run();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using the Mindfulness Program!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}