using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(30, 4.8));
        activities.Add(new Cycling(30, 9.6));
        activities.Add(new Swimming(30, 100));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
