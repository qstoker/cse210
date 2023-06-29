public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity() { }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(5);

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            seconds--;
        }
    }
}
