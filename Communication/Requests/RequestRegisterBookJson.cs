using BookStore;

namespace Bookstore.Communication.Requests;

public class RequestRegisterBookJson
{    
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public double Price { get; set; }
    public int QuantityInStock { get; set; }
    public BookType Type { get; set; }
}
