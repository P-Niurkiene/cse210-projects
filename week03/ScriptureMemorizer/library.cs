
public class ScriptureLibrary
{
    private string _filename;

    public ScriptureLibrary(string filename)
    {
        _filename = filename;
    }

    public string GetRandomVerse()
    {
        if (!File.Exists(_filename)) return null;

        string[] lines = File.ReadAllLines(_filename);
        Random rand = new Random();
        return lines[rand.Next(lines.Length)];
    }

    public string GetVerseByReference(string reference)
    {
        if (!File.Exists(_filename)) return null;

        string[] lines = File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 2 && parts[0].Equals(reference, StringComparison.OrdinalIgnoreCase))
                return line;
        }
        return null;
    }
}
