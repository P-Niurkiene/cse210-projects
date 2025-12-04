// To make the quest more like a game I have adde the aspect that with every 1000 point you earn a sweet treat.
// A talley is kept in the Goals txt and is shown at the top how many points away you are, to keep the person motivated.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager(0);
        manager.Start();


    }
}