using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Address address1 = new Address("111 Street Road", "City 1", "State 1", "Country of 1");
        Address address2 = new Address("222 Street Road", "City 2", "State 2", "Country of 2");
        Address address3 = new Address("333 Street Road", "City 3", "State 3", "Country of 3");

        Lecture lecture = new Lecture(
            "Lecture",
            "Person Speaking to People",
            "There will be lots of talking at this fun event.",
            "01-01-2025",
            "12PM UTC",
            address1,
            "Talkative Person",
            200
        );

        Reception reception = new Reception(
            "Reception",
            "Happy Celebration",
            "There will be lots of food at this fun event.",
            "02-02-2025",
            "1PM UTC",
            address2,
            "rsvp_email@email.com"
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Outdoor Gathering",
            "Walking on Grass",
            "So much walking on grass at this exciting gathering.",
            "03-03-2025",
            "2PM UTC",
            address3,
            "Cloudy"
        );

        Console.WriteLine($"Event 1:");
        Console.WriteLine($"---------------");
        Console.WriteLine(lecture.ListShortDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ListStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ListFullDetails());
        Console.WriteLine($"---------------\n");

        Console.WriteLine($"Event 2:");
        Console.WriteLine($"---------------");
        Console.WriteLine(reception.ListShortDetails());
        Console.WriteLine();
        Console.WriteLine(reception.ListStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.ListFullDetails());
        Console.WriteLine($"---------------\n");

        Console.WriteLine($"Event 3:");
        Console.WriteLine($"---------------");
        Console.WriteLine(outdoorGathering.ListShortDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.ListStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.ListFullDetails());
        Console.WriteLine($"---------------\n");
    }
}
