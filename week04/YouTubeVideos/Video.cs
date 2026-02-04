public class Video
{
    private string _tittle;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string tittle, string author, int length) {
        _tittle = tittle;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment) {
        _comments.Add(comment);
    }

    public int GetNumbeOfComments() {
        return _comments.Count;
    }
    public void DisplayVideoInfo() {
        Console.WriteLine($"{_tittle} by {_author}, {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumbeOfComments()}");
    }
    public void DisplayAllComments(){
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }
    }
}