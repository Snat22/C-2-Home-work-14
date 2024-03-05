namespace Task3;

public class Book : AbstractBook , Borrowable
{
    public string Title { get; set; }

    public string Author { get; set; } 

    public void Borrow()
    {
        System.Console.WriteLine("book has been borrowed.");
    }

    public void ReturnBook()
    {
        System.Console.WriteLine("book has been returned.");
    }
}
