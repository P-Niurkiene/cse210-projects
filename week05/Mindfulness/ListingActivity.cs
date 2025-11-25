public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private Random _random = new Random();

    public Listing(string name, string description)
        : base(name, description)
    {
        _prompts.Add("What are some things you are grateful for?");
        _prompts.Add("Who are people that help you in your life?");
        _prompts.Add("What are some acts of kindness you’ve recently seen?");
    }

    public void Run()
    {
        int seconds = DisplayStartingMessage();

        Console.WriteLine("List as many items as you can.");
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(2);

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}
