using BookStore;

namespace Bookstore.Communication.Responses;

public class ResponseRegisterBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public double Price { get; set; }
    public int QuantityInStock { get; set; }
    public BookType Type { get; set; }
}
