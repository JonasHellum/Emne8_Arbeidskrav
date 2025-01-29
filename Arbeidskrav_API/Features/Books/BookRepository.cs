using Arbeidskrav_API.Data;
using Arbeidskrav_API.Features.Books.Classes;
using Arbeidskrav_API.Features.Books.Interface;

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
        throw new NotImplementedException();
    }

    public async Task<Book> AddAsync(BookDTO bookDto)
    {
        throw new NotImplementedException();
    }
}