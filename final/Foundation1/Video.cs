using System.Transactions;

public class Video
{
     private string _author;
    private string _title;
    private int _lenght;
    
    private List<Comment> _comments;
    {
        _author = author;
        _title = title;
        _lenght = lenght;
        _comments = new List<Comment>();
    }

    public void AddComment(string author, string comment)
    {
        Comment newComment = new Comment(author, comment);
        _comments.Add(newComment);
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine("\n--- COMMENTS ---");
        foreach(CommittableTransaction comment in _comments)
        {
            Console.WriteLine($"{comment.GetUserName()}\n {comment.GetComment()}");
        }
    }

    public string GetLengthInHHMMSS()
    {
        TimeSpan time = TimeSpan.FromSeconds(_lenght);
        return time.ToString(@"hh\:mm\:ss");
    }

    //Getters
    public string GetAuthor()
    {
        return _author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetLength()
    {
        return _length;
    }

    public string GetCommentsCount()
    {
        return _comments.Count();
    }


}