public class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string name, string content)
    {
        Comment comment = new Comment(name, content);
        _comments.Add(comment);
    }

    public int CommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title}, from {_author} - ({_length} seconds)");
    }

    public void DisplayComments()
    {
        Console.WriteLine($"{CommentCount()} comments:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()} - {comment.GetContent()}");
        }

        Console.WriteLine();
    }
}
