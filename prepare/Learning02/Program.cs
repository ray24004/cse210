using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Happy S.A.";
        job1._startYear = 2020;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Game Designer";
        job2._company = "Nasray Game Studio";
        job2._startYear = 2016;
        job2._endYear = 2020;

        Resume resume = new Resume();
        resume._personName = "Wesley Raymundo";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}