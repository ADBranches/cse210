using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectingActivity()
        {
            _name = "Reflecting";
            _description = "This activity will help you reflect on times of strength and resilience.";
        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("\nConsider the following prompt:");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on these questions:");
            ShowCountDown(5);

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write($"\n> {GetRandomQuestion()} ");
                ShowSpinner(5);
            }

            DisplayEndingMessage();
        }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            return _prompts[rand.Next(_prompts.Count)];
        }

        private string GetRandomQuestion()
        {
            Random rand = new Random();
            return _questions[rand.Next(_questions.Count)];
        }
    }
}
