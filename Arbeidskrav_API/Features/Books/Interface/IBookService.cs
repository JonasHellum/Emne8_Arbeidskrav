using Arbeidskrav_API.Features.Books.Classes;

namespace Arbeidskrav_API.Features.Books.Interface;

public interface IBookService
{
    Task<IEnumerable<BookDTO>> GetAllAsync();
    Task<BookDTO> AddAsync(BookRegistrationDTO addDto);
}