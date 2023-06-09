using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int answer = -1;
        int sum = 0;
        float average = 0;
        int largestNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (answer != 0)
        {
            Console.Write("Enter number: ");
            answer = int.Parse(Console.ReadLine());
            if (answer != 0)
            {
                numbers.Add(answer);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;

            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        average = (float)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}
