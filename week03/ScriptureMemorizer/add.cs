public class Add
{
    string filename = "verses.txt";

    public void addQuestion()
    {
        Console.Write("What verse would you like to add? ");
        string verse = Console.ReadLine();
        File.AppendAllText(filename, verse + Environment.NewLine);
        Console.WriteLine("Your verse has been added!");
    }


}