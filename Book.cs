namespace Bookstore;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int QuantityInStock { get; set; }

    public Gender Genre { get; set; }
}

public enum Gender
{
    Romance,
    Fantasy,
    Mystery,
    ScienceFiction,
    Thriller,
    HistoricalFiction,
    NonFiction
}
