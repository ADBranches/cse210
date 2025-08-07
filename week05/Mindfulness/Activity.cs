using System;
using System.Threading;

namespace Mindfulness
{
    public class Activity
    {
        protected string _name;          
        protected string _description;   
        protected int _duration;         

        public Activity()
        {
            _name = "";
            _description = "";
            _duration = 0;
        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {_name} Activity!");
            Console.WriteLine(_description);
            Console.Write("How long (in seconds) would you like your session? ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready...");
            ShowSpinner(3);  
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("Good job!");
            Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
            ShowSpinner(3);
        }

        public void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds * 2; i++)
            {
                Console.Write("/"); Thread.Sleep(250);
                Console.Write("\b \b"); Console.Write("-"); Thread.Sleep(250);
                Console.Write("\b \b"); Console.Write("\\"); Thread.Sleep(250);
                Console.Write("\b \b"); Console.Write("|"); Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}
