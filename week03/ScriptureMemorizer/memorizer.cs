
public class Memorizer
{
    public void StartMemorization(string line)
    {
        string[] parts = line.Split('|');
        Reference reference = new Reference(parts[0], 1, 1); // placeholder
        Scripture scripture = new Scripture(reference, parts[1]);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to stop:");
            string input = Console.ReadLine().ToLower();

            if (input == "quit") break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\n🎉 All words are hidden! Well done!");
                break;
            }
        }
    }
}
