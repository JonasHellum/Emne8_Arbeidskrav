using Arbeidskrav_API.Data;
using Arbeidskrav_API.Features.Books.Classes;
using Arbeidskrav_API.Features.Books.Interface;
using Microsoft.EntityFrameworkCore;

namespace Arbeidskrav_API.Features.Books;

public class BookRepository : IBookRepository
{
    private readonly ArbeidskravAPIDbContext _dbContext;
    
    public BookRepository(ArbeidskravAPIDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Book>> GetAllsync()
    {
        var books = await _dbContext.Books.ToListAsync();
        return books;
    }

    public async Task<Book> AddAsync(Book book)
    {
        await _dbContext.Books.AddAsync(book);
        await _dbContext.SaveChangesAsync();
        return book;
    }
}