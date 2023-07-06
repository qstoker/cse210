using System;

// I added a spinner to pause the clearing of the
// console at certain points and a level system
// that requires higher and higher amounts of
// points to level up each time.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.Start();
    }
}
