public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.Write(
          $"""
          Welcome to the {_name}.

          {_description}

          How long, in seconds, would you like for your session? 
          """  
        );
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime targetTime = DateTime.Now.AddSeconds(seconds);

        char[] frames = {'|', '/', '-', '\\',};
        int frameIndex = 0;

        Console.Write(' ');
        while (DateTime.Now < targetTime)
        {
            Console.Write($"\b{frames[frameIndex]}");

            if (++frameIndex >= frames.Length)
            {
                frameIndex = 0;
            }

            Thread.Sleep(250);
        }

        Console.WriteLine("\b ");
    }

    public void ShowCountdown(int seconds)
    {
        Console.Write(" ");
        while (seconds > 0)
        {
            Console.Write($"\b{seconds}");
            Thread.Sleep(1000);
            seconds--;
        }

        Console.WriteLine("\b ");
    }
}