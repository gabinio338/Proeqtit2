using System;
using System.Collections.Generic;

public class BookManager
{
    private List<Book> books = new List<Book>();

    // წიგნის დამატება
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("The book was successfully added!");
    }

    // ყველა წიგნის ნახვა
    public void ShowAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Console.WriteLine(" Books List:");
        foreach (var book in books)
        {
            Console.WriteLine(book.ToString());
        }
        Console.WriteLine();
    }

    // ძებნა სათაურით
    public void SearchByTitle(string title)
    {
        var found = books.Find(b => b.Title.ToLower() == title.ToLower());

        if (found == null)
            Console.WriteLine("No such book was found");
        else
            Console.WriteLine("Found: " + found.ToString()");
    }
}
