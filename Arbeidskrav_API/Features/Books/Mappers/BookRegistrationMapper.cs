using Arbeidskrav_API.Features.Books.Classes;
using Arbeidskrav_API.Features.Books.Interface;

namespace Arbeidskrav_API.Features.Books.Mappers;

public class BookRegistrationMapper : IBookRegistrationMapper
{
    public BookRegistrationDTO MapToDTO(Book book)
    {
        return new BookRegistrationDTO()
        {
            Author = book.Author,
            Title = book.Title,
            Published = book.Published
        };
    }

    public Book MapToModel(BookRegistrationDTO bookDTO)
    {
        return new Book()
        {
            Author = bookDTO.Author,
            Title = bookDTO.Title,
            Published = bookDTO.Published
        };
    }
}