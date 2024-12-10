public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime targetTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < targetTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(3);

            Console.Write("Now breathe out...");
            ShowCountdown(3);

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}