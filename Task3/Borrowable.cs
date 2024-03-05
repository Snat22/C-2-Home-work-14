namespace Task3;

public interface Borrowable
{
    void Borrow()
    {
        System.Console.WriteLine("book has been borrowed.");
    }
    void ReturnBook()
    {
        System.Console.WriteLine("book has been returned.");
    }
}
