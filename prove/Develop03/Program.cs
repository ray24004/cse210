using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine();

        RandomScripturePicker randomScripturePicker = new RandomScripturePicker("./scriptures.csv", "|");
        Scripture scripture = randomScripturePicker.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press enter to hide some words or type \"quit\": ");
            string response = Console.ReadLine();

            if (response == "quit" || scripture.GetIsCompletelyHidden())
            {
                break;
            }

            scripture.HideWords(3);
        }
    }
}