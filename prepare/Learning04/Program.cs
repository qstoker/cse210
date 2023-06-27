using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment multiplication = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(multiplication.GetSummary());

        Console.WriteLine();

        MathAssignment fractions = new MathAssignment(
            "Roberto Rodriguez",
            "Fractions",
            "7.3",
            "8-19"
        );
        Console.WriteLine(fractions.GetSummary());
        Console.WriteLine(fractions.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment europeanHistory = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );
        Console.WriteLine(europeanHistory.GetSummary());
        Console.WriteLine(europeanHistory.GetWritingInformation());
    }
}
