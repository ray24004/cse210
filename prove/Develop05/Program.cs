using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine();

        while(true)
        {
            switch (RequestMenuOption())
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    return;
            }
        }
    }

    private static string RequestMenuOption()
    {
        Console.Clear();

        Console.WriteLine(
            """
            Menu Options:
                1. Start breathing activity
                2. Start reflecting activity
                3. Start listing activity
                4. Quit
            Select a choice from the menu:             
            """
        );

        return Console.ReadLine();
    }
}