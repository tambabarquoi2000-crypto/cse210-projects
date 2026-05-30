public class Comment
{
    private string _commenter = "";
    private string _comentTxt = "";

    public Comment()
    {
        _commenter = "";
        _comentTxt = "";
    }

    public Comment(string commenter)
    {
        _commenter = commenter;
        _comentTxt = "";
    }

    public void WriteComment(string cmtTxt)
    {
        _comentTxt = cmtTxt;
    }

    public string getComment()
    {
        return $"{_commenter}: {_comentTxt}";
    }
}