using System;

class Program
{
    static Journal journal = new Journal();
    static PromptGenerator promptGenerator = new PromptGenerator();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        string chosenOption = "";
        while (chosenOption != "5")
        {
            chosenOption = PromptActionOption();

            switch (chosenOption)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    SaveToFile();
                    break;
                case "4":
                    LoadFromFile();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Invalid option. Please, try again.");
                    break;
            }
        }
    }

    static string PromptActionOption()
    {
        Console.WriteLine();
        Console.Write("""
        === JOURNAL MENU
        1. Write new entry
        2. Display all entries
        3. Save to file
        4. Load from file
        5. Exit

        Type desired option number: 
        """);

        string chosenOption = Console.ReadLine();
        Console.WriteLine();

        return chosenOption;
    }

    static void WriteNewEntry()
    {
        string todayDate = DateTime.Now.ToShortDateString();
        string randomPrompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine($"{todayDate} - {randomPrompt}");
        Console.Write("Response: ");
        string response = Console.ReadLine();

        journal.AddEntry(new Entry()
        {
            _date = todayDate,
            _promptText = randomPrompt,
            _entryText = response
        });
    }

    static void DisplayEntries()
    {
        journal.DisplayAll();
    }

    static void SaveToFile()
    {
        Console.Write($"Type desired filename: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void LoadFromFile()
    {
        Console.Write($"Type the filename: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}