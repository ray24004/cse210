public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    private Random random = new Random();

    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}