using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();

        Console.Write("What is your grade percentage? ");
        float percentage = float.Parse(Console.ReadLine());

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }


        string sign = "";

        if (percentage % 10 >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (percentage % 10 < 3 && letter != "F")
        {
            sign = "-";
        }


        Console.WriteLine();
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percentage >= 70) 
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else 
        {
            Console.WriteLine("Sorry, you didn't pass the test; please try again.");
        }
    }
}