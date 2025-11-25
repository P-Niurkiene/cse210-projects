// Addtional Class added to show insprational quotes.
using System;

class Program
{
    static void Main(string[] args)
    {
        string activity = "";
        Console.WriteLine("Welcome to the Mindful Program to help reduce the stress of life. Please select you actvity by entering the consiponding number.");
        while (activity != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Postive Words Activity");
            Console.WriteLine("5. Quit");

            activity = Console.ReadLine();

            if (activity == "1")
            {
                Breathing breathing = new Breathing("Breathing", "Slow down your heart and mind through deep breaths");
                breathing.Run();
            }
            else if (activity == "2")
            {
                Reflection reflection = new Reflection("Reflecting", "Look back at you life experiences");
                reflection.Run();
            }
            else if (activity == "3")
            {
                Listing list = new Listing("List", "Make a list to highlight the postive things in your life", 5);
                list.Run();
            }
            else if (activity == "4")
            {
                PositiveWords quote = new PositiveWords("Insprational Quotes", "Feel uplifted and inspired but the wise words of others");
                quote.Run();
            }
            else if (activity == "5")
            {
                Console.WriteLine("Thank you for using the Mindful Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
            }

        }


    }
}