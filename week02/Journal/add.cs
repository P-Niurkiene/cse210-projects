public class Add
{
    string filename = "questions.txt";

    public void addQuestion()
    {
        Console.Write("What new question would you like to add? ");
        string question = Console.ReadLine();
        File.AppendAllText(filename, question + Environment.NewLine);
        Console.WriteLine("Your question has been added!");
    }


}