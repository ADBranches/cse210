using System;
using System.Threading;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            _name = "Breathing";
            _description = "This activity will help you relax by guiding you through slow breathing. Focus on your breath.";
        }

        public void Run()
        {
            DisplayStartingMessage();

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("\nBreathe in...");
                ShowCountDown(4);
                Console.WriteLine("\nBreathe out...");
                ShowCountDown(6);
            }

            DisplayEndingMessage();
        }
    }
}
