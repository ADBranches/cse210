public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment) => _comments.Add(comment);
    public int GetCommentCount() => _comments.Count;
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
        }
        Console.WriteLine();
    }
}
