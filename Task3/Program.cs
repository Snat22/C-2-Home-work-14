
using Task3;

var book1 = new Book();
System.Console.WriteLine($"Title: {book1.Title = "Sarlavhai"}");
System.Console.WriteLine($"Author: {book1.Author = "Maruf"}");
book1.Read();
book1.Borrow();
book1.ReturnBook();