using Arbeidskrav_API.Features.Books.Classes;
using Arbeidskrav_API.Features.Books.Interface;

namespace Arbeidskrav_API.Features.Books;

public class BookService : IBookService
{
    public async Task<IEnumerable<BookDTO>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<BookDTO> AddAsync(BookRegistrationDTO addDto)
    {
        throw new NotImplementedException();
    }
}