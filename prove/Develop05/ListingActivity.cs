public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        Console.Write(
            $"""
            List as many responses you can to the following prompt:

                --- {GetRandomPrompt()} ---

            You may begin in: 
            """
        );

        ShowCountdown(5);

        _count = GetListFromUser().Count;

        Console.WriteLine($"You listed {_count} items!\n");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        DateTime targeTime = DateTime.Now.AddSeconds(_duration);

        List<string> userList = new List<string>();
        while (DateTime.Now < targeTime)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        }
        
        return userList;
    }
}