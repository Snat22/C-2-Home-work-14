namespace Task3;

public class AbstractBook : Readable
{
    string _title;
    string _author;

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }
    public string GetAuthor()
    {
        return _author;
    }

    public void Read()
    {
        System.Console.WriteLine("Reading ");
    }
}
