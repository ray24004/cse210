using System;

class Program
{
    // EXCEEDING REQUIREMENTS: Improved the process of saving 
    // and loading to save as a .csv file that could be opened in Excel,
    // making sure to account for quotation marks and commas correctly in the content.
    // (feature present in Entry.cs file)
    
    
    static Journal journal = new Journal();
    static PromptGenerator _promptGenerator = new PromptGenerator();

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
                    DisplayAllEntries();
                    break;
                case "3":
                    SaveEntriesToFile();
                    break;
                case "4":
                    LoadEntriesFromFile();
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
        string randomPrompt = _promptGenerator.GetRandomPrompt();

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

    static void DisplayAllEntries()
    {
        journal.DisplayAll();
    }

    static void SaveEntriesToFile()
    {
        Console.Write($"Type desired filename (example.csv): ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void LoadEntriesFromFile()
    {
        Console.Write($"Type the filename (example.csv): ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}