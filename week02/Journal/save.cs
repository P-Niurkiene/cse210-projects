public class Save
{
    string filename = "My_Journal.txt";

    public void SaveEntry(string question, string answer)
    {
        DateTime theCurrentDate = DateTime.Now;
        string dateText = theCurrentDate.ToShortDateString();
        string entry = $"{dateText}: Prompt: {question} {answer}";
        File.AppendAllText(filename, entry + Environment.NewLine);
        Console.WriteLine("Your entry/entries have been saved!");
    }
}