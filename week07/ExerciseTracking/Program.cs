using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("16 Feb 2026", 18, 3.2));
        activities.Add(new Cycling("17 Feb 2026", 30, 9.7));
        activities.Add(new Swimming("15 Jan 2026", 25, 20));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}