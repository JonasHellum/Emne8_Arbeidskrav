using Arbeidskrav_API.Features.Books.Classes;
using Arbeidskrav_API.Features.Books.Interface;

namespace Arbeidskrav_API.Features.Books.Mappers;

public class BookRegistrationMapper : IBookMapper
{
    public BookDTO MapToDTO(Book book)
    {
        return new BookDTO()
        {
            Author = book.Author,
            Title = book.Title,
            Published = book.Published
        };
    }

    public Book MapToModel(BookDTO bookDTO)
    {
        return new Book()
        {
            Author = bookDTO.Author,
            Title = bookDTO.Title,
            Published = bookDTO.Published
        };
    }
}