public class write
{
    string filename = "questions.txt";
    Random rand = new Random();

    public void DisplayRandomLine()
    {
        string[] lines = File.ReadAllLines(filename);
        string randomLine = lines[rand.Next(lines.Length)];
        Console.WriteLine(randomLine);
        Console.Write("-");
        string answer = Console.ReadLine();
    }

}