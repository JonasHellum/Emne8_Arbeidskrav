using Arbeidskrav_API.Features.Books.Classes;
using Arbeidskrav_API.Features.Books.Interface;

namespace Arbeidskrav_API.Features.Books.Mappers;

public class BookMapper : IBookMapper
{
    public BookDTO MapToDTO(Book book)
    {
        return new BookDTO()
        {
            Id = book.Id,
            Author = book.Author,
            Title = book.Title,
            Published = book.Published
        };
    }

    public Book MapToModel(BookDTO bookDTO)
    {
        return new Book()
        {
            Id = bookDTO.Id,
            Author = bookDTO.Author,
            Title = bookDTO.Title,
            Published = bookDTO.Published
        };
    }
}