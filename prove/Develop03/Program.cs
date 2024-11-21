using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine();

        Reference reference = new Reference("1 Nephi", 10, 19, 20);
        string text = "For he is the same yesterday, today, and forever; and the way is prepared for all men from the foundation of the world, if it so be that they repent and come unto him. For he that diligently seeketh shall find; and the mysteries of God shall be unfolded unto them, by the power of the Holy Ghost, as well in these times as in times of old, and as well in times of old as in times to come; wherefore, the course of the Lord is one eternal round.";

        Scripture scripture = new Scripture(reference, text);

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

            scripture.HideWords(2);
        }
    }
}