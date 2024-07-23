using Bookstore.Communication.Requests;
using Bookstore.Communication.Responses;
using BookStore;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers;
[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisterBookJson
        {
            Id = 8,
            Title = request.Title,
            Author = request.Author,
            Price = request.Price,
            QuantityInStock = request.QuantityInStock,
            Type = request.Type
        };

        return Created(string.Empty, response);
    }


    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetAll()
    {
        var response = new List<Book>
        {
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 12.99m, QuantityInStock = 20, Type = BookType.Romance },
            new Book { Id = 2, Title = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Price = 24.99m, QuantityInStock = 15, Type = BookType.Fantasy },
            new Book { Id = 3, Title = "Murder on the Orient Express", Author = "Agatha Christie", Price = 9.99m, QuantityInStock = 30, Type = BookType.Mystery },
            new Book { Id = 4, Title = "Dune", Author = "Frank Herbert", Price = 18.50m, QuantityInStock = 25, Type = BookType.ScienceFiction },
            new Book { Id = 5, Title = "Gone Girl", Author = "Gillian Flynn", Price = 14.75m, QuantityInStock = 18, Type = BookType.Thriller },
            new Book { Id = 6, Title = "The Nightingale", Author = "Kristin Hannah", Price = 10.00m, QuantityInStock = 22, Type = BookType.HistoricalFiction },
            new Book { Id = 7, Title = "Sapiens: A Brief History of Humankind", Author = "Yuval Noah Harari", Price = 16.99m, QuantityInStock = 12, Type = BookType.NonFiction }
        };

        return Ok(response);
    }
}
