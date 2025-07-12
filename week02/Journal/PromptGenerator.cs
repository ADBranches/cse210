public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        // Additional prompts to exceed requirements
        "What small act of kindness did I perform or witness today?",
        "What lesson did I learn today that I want to remember?",
        "How did I take care of my physical/mental health today?"
    };
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}