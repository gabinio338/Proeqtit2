using System;

public class ConsoleUI
{
    private BookManager manager = new BookManager();

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Book management system ");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. View the list of books");
            Console.WriteLine("3. Search for a book (by title)");
            Console.WriteLine("4.Exit");
            Console.Write("Choose: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1": AddBookUI();
                    break;
                case "2": manager.ShowAllBooks();
                    break;
                case "3": SearchBookUI();
                    break;
                case "4": return;
                default: Console.WriteLine("Wrong choise.\n");
                    break;
            }
        }
    }

    private void AddBookUI()
    {
        Console.Write("Enter a title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the author: ");
        string author = Console.ReadLine();

        Console.Write("Enter the year: ");

        if (!int.TryParse(Console.ReadLine(), out int year))
        {
            Console.WriteLine("The year must be a number!\n");
            return;
        }

        Book book = new Book(title, author, year);
        manager.AddBook(book);
    }

    private void SearchBookUI()
    {
        Console.Write("Enter a title: ");
        string title = Console.ReadLine();

        manager.SearchByTitle(title);
    }
}
