public class Display
{
    public void DisplayEntry(string question, string answer, DateTime? entryDate = null)
    {
        DateTime date = entryDate ?? DateTime.Now;
        string dateText = date.ToShortDateString();
        Console.WriteLine($"Date: {dateText} | Prompt: {question} | Answer: {answer}");
    }
}