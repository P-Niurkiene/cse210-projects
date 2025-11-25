public class Listing : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private Random _random = new Random();

    public Listing(string name, string description, int count)
        : base(name, description)
    {
        _count = count;
        _prompts.Add("What are 5 things you are grateful for?");
        _prompts.Add("Who are 5 people you are thankful for?");
        _prompts.Add("What are 5 things that made you smile today?");
    }

    public void Run()
    {
        int seconds = DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        ShowSpinner(3);
        ShowCountdown(seconds);
        List<string> items = GetListFromUser();

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
