public class Breathing : Activity
{
    public Breathing(string name, string description, string duration)
        : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("How long would you like to do this exercise for (seconds)?");
        int totalSeconds = int.Parse(Console.ReadLine());
        int inhaleTime = 3;
        int exhaleTime = 5;
        int elapsed = 0;

        while (elapsed < totalSeconds)
        {
            Console.WriteLine("Breathe in: ");
            for (int i = inhaleTime; i > 0; i--)
            {
                Console.Write($"\r{i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            elapsed += inhaleTime;

            if (elapsed >= totalSeconds) break;

            Console.WriteLine("Breathe out: ");
            for (int i = exhaleTime; i > 0; i--)
            {
                Console.Write($"\r{i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            elapsed += exhaleTime;
        }

        DisplayEndingMessage();
    }

}
