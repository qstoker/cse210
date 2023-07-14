using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(30, 4.8));
        activities.Add(new Cycling(40, 12));
        activities.Add(new Swimming(15, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
