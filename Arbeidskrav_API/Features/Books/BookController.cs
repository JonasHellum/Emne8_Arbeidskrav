using Arbeidskrav_API.Features.Books.Classes;
using Arbeidskrav_API.Features.Books.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Arbeidskrav_API.Features.Books;

[ApiController]
[Route("api/v1/books")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }
    
    [HttpGet("GetBooks", Name = "GetBooksAsync")]
    public async Task<ActionResult<IEnumerable<BookDTO>>> GetAllAsync()
    {
        var bookDtos = await _bookService.GetAllAsync();
        return Ok(bookDtos);
    }

    [HttpPost("AddBook", Name = "AddBookAsync")]
    public async Task<ActionResult<BookDTO>> AddAsync([FromBody] BookRegistrationDTO addDto)
    {
        var bookDto = await _bookService.AddAsync(addDto);
        return bookDto is null
            ? BadRequest("Failed to add book")
            : Ok(bookDto);
    }
}