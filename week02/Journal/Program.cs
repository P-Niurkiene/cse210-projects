using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        List<(string question, string answer)> entries = new List<(string, string)>();

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
                write entry = new write();
                var (question, answer) = entry.DisplayRandomLine();
                entries.Add((question, answer));
            }
            else if (choice == "2")
            {
                if (entries.Count == 0)
                {
                    foreach (var entry in entries)
                    {
                        Display show = new Display();
                        show.DisplayEntries(entry.question, entry.answer);
                    }
                }
                else if (choice == "3")
                {
                    Load journal = new Load();
                    journal.LoadJournal();
                }
                else if (choice == "4")
                {
                    if (entries.Count == 0)
                    {
                        Console.Write("Whoops, there is nothing to save!");
                    }
                    else
                    {
                        foreach (var entry in entries)
                        {
                            Save saving = new Save();
                            saving.SaveEntry(entry.question, entry.answer);
                        }
                        entries.Clear();
                    }
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
}