using System;

// I exceeded requirements by ensuring the Reflecting
// Activity's questions don't repeat until they have
// all been used (while still randomizing the order).

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        BreathingActivity breathingActivity;
        ReflectingActivity reflectingActivity;
        ListingActivity listingActivity;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
            }
        }
    }
}
