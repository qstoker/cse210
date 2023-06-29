public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description =
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int countdown = _duration;

        while (countdown > 0)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountdown(5);

            Console.Write("\nNow breathe out...");
            ShowCountdown(5);

            countdown -= 10;
        }

        DisplayEndingMessage();
    }
}
