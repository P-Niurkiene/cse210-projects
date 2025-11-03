public class Save
{


    public void SaveEntry(string question, string answer)
    {
        Console.Write("Which file would you like to save to? ");
        string filename = Console.ReadLine();
        DateTime theCurrentDate = DateTime.Now;
        string dateText = theCurrentDate.ToShortDateString();
        string entry = $"Date: {dateText} | Prompt: {question} | Answer: {answer}";
        File.AppendAllText(filename, entry + Environment.NewLine);
        Console.WriteLine("Your entry/entries have been saved!");
    }
}