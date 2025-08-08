/* MORE ADDED REQUIREMENTS...
 * 1. Added negative goals (deduct points for bad habits).
 * 2. Level-up system: Celebrate every 1000 points with ASCII art.
 * 3. Prevented duplicate goal names to avoid confusion.
 */
class Program
{
    static void Main()
    {
        Console.WriteLine("🌟 Eternal Quest Program 🌟");
        new GoalManager().Start();
    }
}
