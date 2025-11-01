public class Load
{
    string filename = "My_Journal.txt";

    public void LoadJournal()
    {
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