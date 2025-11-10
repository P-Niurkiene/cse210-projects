
public class Add
{
    private string filename = "verses.txt";

    public void AddVerse()
    {
        Console.Write("What verse would you like to add? ");
        string verse = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(verse))
        {
            File.AppendAllText(filename, verse + Environment.NewLine);
            Console.WriteLine("Your verse has been added!");
        }
        else
        {
            Console.WriteLine("You didn't type anything — nothing was added.");
        }
    }
}
