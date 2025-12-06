using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();
        List<Activity> activities = new List<Activity>();

        Running r1 = new Running(5, 30);
        activities.Add(r1);

        Swimming s1 = new Swimming(10, 60);
        activities.Add(s1);

        Cycling c1 = new Cycling(10, 45);
        activities.Add(c1);

        Console.WriteLine("Actvity Summaries:");
        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            activity.DisplaySummary();
        }



    }
}