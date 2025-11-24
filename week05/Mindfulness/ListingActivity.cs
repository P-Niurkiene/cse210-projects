public class Listing : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private Random _random = new Random();

    public Listing(string name, string description, string duration, int count)
        : base(name, description, duration)
    {
        _count = count;
        _prompts.Add("What are 5 things you are grateful for?");
        _prompts.Add("Who are 5 people you are thankful for?");
        _prompts.Add("WHat are 5 things that made you smile today?");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("How long would you like to do this exercise for (seconds)?");
        int seconds = int.Parse(Console.ReadLine());
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        ShowSpinner(3);
        List<string> items = GetListFromUser();
        ShowCountdown(seconds);
        Console.WriteLine(items);

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        Console.WriteLine($"List {_count} things:");

        for (int i = 0; i < _count; i++)
        {
            items.Add(Console.ReadLine());
        }

        return items;
    }
}
