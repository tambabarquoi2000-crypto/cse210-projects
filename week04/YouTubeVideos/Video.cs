public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0;
    private List<Comment> _comments = new List<Comment>();

    // Constructor used to create a video object without passing arguements
    public Video()
    {
        _title = "";
        _author = "";
        _length = 0;
        _comments = new List<Comment>();
    }

    // Contructor used to create a video object while passing the necessary arguements
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Member functions

    public void MakeComment(string commenter, string commentTxt)
    {
        Comment newComment = new Comment(commenter);
        newComment.WriteComment(commentTxt);
        _comments.Add(newComment);
    }

    public int ClcTotalComments()
    {
        int totalComments = 0;
        foreach(Comment cmt in _comments)
        {
            totalComments ++;
        }

        return totalComments;
    }

    public void ViewAllComments()
    {
        foreach(Comment cmt in _comments)
        {
            Console.WriteLine(cmt.getComment());
        }
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title  }");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}s");
    }
}