public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private Random _random = new Random();

    public Reflection(string name, string description, string duration)
        : base(name, description, duration)
    {
        _prompts.Add("Think about a time you overcame a challenge.");
        _prompts.Add("Reflect on something you are grateful for today.");

        _questions.Add("What did you learn from this experience?");
        _questions.Add("How can you apply this lesson in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("How long would you like to do this exercise for (seconds)?");
        int seconds = int.Parse(Console.ReadLine());
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        ShowSpinner(3);
        string question = GetRandomQuestion();
        Console.WriteLine(question);
        ShowCountdown(seconds);

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }
}
