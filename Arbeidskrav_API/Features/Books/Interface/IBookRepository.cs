using Arbeidskrav_API.Features.Books.Classes;

namespace Arbeidskrav_API.Features.Books.Interface;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetAllsync();
    Task<Book> AddAsync(BookDTO bookDto);
}