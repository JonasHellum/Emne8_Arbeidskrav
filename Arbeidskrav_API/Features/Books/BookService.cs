using Arbeidskrav_API.Features.Books.Classes;
using Arbeidskrav_API.Features.Books.Interface;

namespace Arbeidskrav_API.Features.Books;

public class BookService : IBookService
{
    
    private readonly IBookRepository _bookRepository;
    private readonly IBookMapper _bookMapper;
    private readonly IBookRegistrationMapper _bookRegistrationMapper;

    public BookService(IBookRepository bookRepository, IBookMapper bookMapper, IBookRegistrationMapper bookRegistrationMapper)
    {
        _bookRepository = bookRepository;
        _bookMapper = bookMapper;
        _bookRegistrationMapper = bookRegistrationMapper;
    }
    public async Task<IEnumerable<BookDTO>> GetAllAsync()
    {
        var books = await _bookRepository.GetAllsync();

        return books.Select(bks => _bookMapper.MapToDTO(bks)).ToList();
    }

    public async Task<BookDTO> AddAsync(BookRegistrationDTO addDto)
    {
        var book = _bookRegistrationMapper.MapToModel(addDto);
        
        var addedBook =  await _bookRepository.AddAsync(book);
        
        return _bookMapper.MapToDTO(addedBook);
    }
}