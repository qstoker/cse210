using System;

// Exceeding requirements:
// Without repeating past prompts, refresh the random
// prompt if the user enters a blank 'Write' input.
// ('Program.cs' and 'PromptGenerator.cs' are the relevant files.)

class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();

        int choice = 0;
        string file = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != 5)
        {
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            Entry currentEntry = new Entry();

            PromptGenerator thePromptGenerator = new PromptGenerator();

            Console.WriteLine("---------------");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------");

            switch (choice)
            {
                case 1:
                    // Write (see comment at top of file)
                    string entryInput = "";

                    while (entryInput == "") // As long as no entry was written
                    { // (i.e. the user asked for a refresh or this is the first run)
                        currentEntry._date = dateText; // Note date

                        currentEntry._promptText = thePromptGenerator.GetRandomPrompt(); // Note prompt
                        Console.WriteLine($"{currentEntry._promptText} ('ENTER' to refresh)");

                        Console.Write("> ");
                        entryInput = Console.ReadLine();
                        currentEntry._entryText = entryInput; // Note entry
                    } // Repeat if entry is blank

                    currentJournal.AddEntry(currentEntry); // Add finalized entry to the journal
                    break;
                case 2:
                    // Display
                    currentJournal.DisplayAll();
                    break;
                case 3:
                    // Load
                    Console.WriteLine("What is the filename?");
                    Console.Write("> ");
                    file = Console.ReadLine();

                    currentJournal.LoadFromFile(file);
                    break;
                case 4:
                    // Save
                    Console.WriteLine("What is the filename?");
                    Console.Write("> ");
                    file = Console.ReadLine();

                    currentJournal.SaveToFile(file);
                    break;
                case 5:
                    // Quit
                    Console.WriteLine("Good job journaling!");
                    break;
                default:
                    // Error
                    Console.WriteLine("Invalid choice. Enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
