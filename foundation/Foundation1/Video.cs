
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

    public string GetDisplayText()
    {
        List<string> lines = new List<string>();
        lines.Add($"Title: {_title}");
        lines.Add($"Author: {_author}");
        lines.Add($"Lenght: {_length} seconds");
        lines.Add($"{GetCommentCount()} comments: ");

        foreach (Comment comment in _comments)
        {
            lines.Add($"\t- {comment.GetDisplayText()}");
        }

        lines.Add("");

        return string.Join('\n', lines);
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}