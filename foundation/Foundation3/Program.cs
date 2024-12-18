using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine();

        List<Activity> activities = new List<Activity>()
        {
            new RunningActivity(DateTime.Now.AddDays(-7), 30, 10),
            new CyclingActivity(DateTime.Now.AddDays(-3), 40, 60),
            new SwimmingActivity(DateTime.Now, 60, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}