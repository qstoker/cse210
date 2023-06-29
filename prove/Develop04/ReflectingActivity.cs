public class ReflectingActivity : Activity
{
    Random _rand; // Exceeding Req
    List<string> _prompts;
    List<string> _questions;
    List<string> _shuffledQuestions; // Exceeding Req
    int _shuffledQuestionIndex; // Exceeding Req

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description =
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _rand = new Random(); // Exceeding Req
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _shuffledQuestions = _questions.OrderBy(question => _rand.Next()).ToList(); // Exceeding Req
        _shuffledQuestionIndex = 0; // Exceeding Req
    }

    public void Run()
    {
        DisplayStartingMessage();
        int countdown = _duration;

        DisplayPrompt();
        Console.WriteLine(
            "Now ponder on each of the following questions as they related to this experience."
        );
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        while (countdown > 0)
        {
            DisplayQuestion();
            ShowSpinner(5);
            Console.WriteLine();

            if (_shuffledQuestionIndex < (_shuffledQuestions.Count() - 1)) // Exceeding Req
            {
                _shuffledQuestionIndex++;
            }
            else
            {
                _shuffledQuestionIndex = 0;
            }
            countdown -= 5;
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = new Random().Next(0, _prompts.Count);
        return _prompts[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {_shuffledQuestions[_shuffledQuestionIndex]} "); // Exceeding Req
    }
}

// Now unused method:
// public string GetRandomQuestion()
// {
//     int index = new Random().Next(0, _questions.Count);
//     return _questions[index];
// }
