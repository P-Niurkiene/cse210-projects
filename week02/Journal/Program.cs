using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Console.WriteLine("Welcome to your Personal Journal!");
        Console.WriteLine("Please select a number of what you would like to do:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Add Prompt");
        Console.WriteLine("6. Quit");

        while (choice != "6")
        {
            Console.Write("Which would you like to do? ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                write question = new write();
                question.DisplayRandomLine();
            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {

            }
            else if (choice == "5")
            {
                Add question = new Add();
                question.addQuestion();
            }
            else
            {
                Console.Write("Thank you for recording your memories today!");
            }

        }



    }
}