using System.Numerics;

public class Video
{
    public string _title;
    public string _author;
    public float _length;
    public List<Comments> _comments = new List<Comments>();

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_author}");
        Console.WriteLine($"{_length} seconds");
    }

    public int GetCommentCount()
    {
        int total = _comments.Count;
        Console.WriteLine($"Comment total for this video is {total}.");
        return total;

    }
}