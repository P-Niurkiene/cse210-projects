public class Display
{
    List<(string question, string answer)> entries = new List<(string, string)>();
    public void DisplayEntries(string question, string answer)
    {
        DateTime theCurrentDate = DateTime.Now;
        string dateText = theCurrentDate.ToShortDateString();
        string entry = $"Date: {dateText}: Prompt: {question} {answer}";
        Console.WriteLine(entry);
    }
}