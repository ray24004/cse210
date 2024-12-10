using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Console.WriteLine();

        Assignment assignment = new Assignment("Wesley Raymundo", "Game Design");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Henrique Nascimento", "Game Physics", "7.1", "8-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Carlos Nasray", "Game History", "How the first videogame was created");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();
    }
}