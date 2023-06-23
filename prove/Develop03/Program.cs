using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(
            reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."
        );

        while (input != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress 'ENTER' to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                input = "quit";
            }

            scripture.HideRandomWords(3);
        }
    }
}
