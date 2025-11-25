public class Activity
{
    private string _name;
    private string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity. {_description}.");
        Thread.Sleep(2000);
        Console.WriteLine("How long would you like to do this exercise for (seconds)?");
        int seconds = int.Parse(Console.ReadLine());
        return seconds;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Thread.Sleep(2000);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}   ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

}
