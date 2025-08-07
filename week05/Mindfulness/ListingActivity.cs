using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private int _count;

        public ListingActivity()
        {
            _name = "Listing";
            _description = "This activity will help you reflect on the good things in your life by listing items.";
        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("\nList as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);

            _count = 0;
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                Console.ReadLine();
                _count++;
            }

            Console.WriteLine($"\nYou listed {_count} items!");
            DisplayEndingMessage();
        }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            return _prompts[rand.Next(_prompts.Count)];
        }
    }
}
