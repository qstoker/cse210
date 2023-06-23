using System;

// 1) I made sure only visible words are chosen to be hidden.

// 2) The user can enter a custom scripture when the program
// starts, if they want.

// 3) I made the scripture visible again once fully hidden
// so the user doesn't have to reenter their custom scripture
// if they only wanted to restart.

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        string book = "Proverbs";
        int chapter = 3;
        int startVerse = 5;
        int endVerse = 6;
        string text =
            "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference;
        Scripture scripture;

        // This allows custom scriptures to be entered:
        Console.Clear();
        Console.WriteLine("Do you want to use a custom scripture?");
        Console.WriteLine("Press 'ENTER' for custom or type 'no' for default:");
        input = Console.ReadLine();
        if (input != "no")
        {
            Console.Clear();
            Console.WriteLine("Great! Is it a single verse or a verse range?");
            Console.WriteLine("Press 'ENTER' for single verse or type 'range' for a range:");
            input = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Okay. What is the book?");
            book = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("What is the chapter?");
            chapter = int.Parse(Console.ReadLine());

            if (input == "range")
            {
                Console.Clear();
                Console.WriteLine("What is the starting verse?");
                startVerse = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("What is the ending verse?");
                endVerse = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Clear();
                Console.WriteLine("What is the verse?");
                startVerse = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("What is the scripture's text?");
            text = Console.ReadLine();
        }

        if (input == "range" || input == "no")
        {
            reference = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            reference = new Reference(book, chapter, startVerse);
        }
        // (End of custom scriptures section)

        scripture = new Scripture(reference, text);

        while (input != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress 'ENTER' to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                scripture.ShowAllWords();
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}
