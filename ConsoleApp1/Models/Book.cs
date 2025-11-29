public class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Year { get; private set; }

    // კონსტრუქტორი - ქმნის წიგნის ობიექტს
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    // წიგნის ინფორმაციის გამოსატანი მეთოდი
    public override string ToString()
    {
        return $" Title: {Title}, Author: {Author}, Year: {Year}";
    }
}
