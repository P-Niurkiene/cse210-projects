public class Load
{

    public void LoadJournal()
    {
        Console.Write("Which file would you like to load from? ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {

            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No journal entries found");
        }


    }
}