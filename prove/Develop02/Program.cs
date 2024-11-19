using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine();

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
        Console.Write("""
        === JOURNAL MENU
        1. Write new entry
        2. Display all entries
        3. Save to file
        4. Load from file
        5. Exit

        Type desired option number: 
        """);

        return Console.ReadLine();
    }

    static void WriteNewEntry()
    {
        Console.WriteLine("Write");
    }

    static void DisplayEntries()
    {
        Console.WriteLine("Display");
    }

    static void SaveToFile()
    {
        Console.WriteLine("Save");
    }

    static void LoadFromFile()
    {
        Console.WriteLine("Load");
    }
}