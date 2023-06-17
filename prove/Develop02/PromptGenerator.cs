// This is part of the 'Exceeding Requirements' described
// at the top of the 'Program.cs' file by ensuring prompts
// aren't repeated before returning to the menu.

public class PromptGenerator
{
    List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the worst part of my day?",
        "What happened for the first time today?",
        "What was the most beautiful thing you saw today?",
        "What was the most beautiful act you saw today?",
        "What did you work on today?",
        "What did you do for fun today?"
    };

    public string GetRandomPrompt()
    {
        if (_prompts.Count > 0) // Still prompts left?
        {
            int index = new Random().Next(0, _prompts.Count);
            string chosenPrompt = _prompts[index];

            _prompts.RemoveAt(index); // Remove prompt

            return chosenPrompt; // Return value of removed prompt
        }
        else // Otherwise
        {
            return "We're out of prompts, sorry."; // Apologize
        }
    }
}
