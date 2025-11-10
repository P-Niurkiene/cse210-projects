// Addtional features added: An Add class so scriptures can be added and stored in a text. All scriptures are stored in a txt allowing them to be stored for future reference. 
// Scriptures are accessed by reference, and can also be selected randomly.
using System;

class Program
{
    static void Main()
    {
        ScriptureLibrary library = new ScriptureLibrary("verses.txt");
        Memorizer memorizer = new Memorizer();
        string choice = "";

        while (choice.ToLower() != "quit")
        {
            Console.WriteLine("1 - Memorize by REFERENCE");
            Console.WriteLine("2 - Memorize RANDOM verse");
            Console.WriteLine("3 - ADD a verse");
            Console.WriteLine("Type 'quit' to exit.");
            choice = Console.ReadLine().ToLower();

            if (choice == "1")
            {
                Console.Write("Enter reference: ");
                string refInput = Console.ReadLine();
                string line = library.GetVerseByReference(refInput);
                if (line != null) memorizer.StartMemorization(line);
                else Console.WriteLine("Reference not found.");
            }
            else if (choice == "2")
            {
                string line = library.GetRandomVerse();
                if (line != null) memorizer.StartMemorization(line);
                else Console.WriteLine("No verses found. Add some first.");
            }
            else if (choice == "3")
            {
                Add adder = new Add();
                adder.AddVerse();
            }
        }

        Console.WriteLine("Great job memorizing today!");
    }
}
