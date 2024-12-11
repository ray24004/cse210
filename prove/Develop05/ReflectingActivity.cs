public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _remainingQuestions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        DisplayQuestions();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        if (_remainingQuestions.Count == 0)
        {
            _remainingQuestions.AddRange(_questions);
        }

        int randomIndex = new Random().Next(_remainingQuestions.Count);
        string randomQuestion = _remainingQuestions[randomIndex];
        _remainingQuestions.RemoveAt(randomIndex);
        
        return randomQuestion;
    }

    private void DisplayPrompt()
    {
        Console.WriteLine(
            $"""
            Consider the following prompt:

                --- {GetRandomPrompt()} ---

            When you have something in mind, press enter to continue.
            """
        );

        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
    }

    private void DisplayQuestions()
    {
        Console.Clear();

        DateTime targetTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < targetTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(5);
        }

        Console.WriteLine();
    }
}