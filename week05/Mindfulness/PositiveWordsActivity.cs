public class PositiveWords : Activity
{
    private List<string> _quotes = new List<string>();
    private Random _random = new Random();

    public PositiveWords(string name, string description, string duration)
        : base(name, description, duration)
    {
        _quotes.Add("Permit yourself to change your mind when something is no longer working for you. - Nedra Glover Tawwab");
        _quotes.Add("Be not afraid of growing slowly; be afraid only of standing still. - Chinese Proverb");
        _quotes.Add("Sometimes good things fall apart so better things could fall together. - Marilyn Monroe");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("How long would you like to do this exercise for (seconds)?");
        int seconds = int.Parse(Console.ReadLine());

        ShowSpinner(3);
        string quote = GetQuote();
        Console.WriteLine(quote);
        ShowCountdown(seconds);

        DisplayEndingMessage();
    }

    public string GetQuote()
    {
        return _quotes[_random.Next(_quotes.Count)];
    }

}
