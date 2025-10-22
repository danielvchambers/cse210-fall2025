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

    public void Display()
    {
        Console.WriteLine($"\n\nTitle: {_title}\nVideo Done By: {_author}\nLength Of The Video: {_length} seconds\nNumber of Comments: {_comments.Count()}");

        foreach (Comment comment in _comments)
        {
            string formatComment = comment.Display();
            Console.WriteLine(formatComment);
        }
    }

    public int NumOfComments()
    {
        int numComments = _comments.Count();
        return numComments;
    }

    public void AddComment(string author, string comment)
    {
        Comment i = new Comment(author, comment);
        _comments.Add(i);
    }
}
