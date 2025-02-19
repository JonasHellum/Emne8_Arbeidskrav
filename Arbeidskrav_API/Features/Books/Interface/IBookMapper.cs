using Arbeidskrav_API.Features.Books.Classes;

namespace Arbeidskrav_API.Features.Books.Interface;

public interface IBookMapper
{
    BookDTO MapToDTO(Book book);
    Book MapToModel(BookDTO bookDTO);
}

public interface IBookRegistrationMapper
{
    BookRegistrationDTO MapToDTO(Book book);
    Book MapToModel(BookRegistrationDTO bookDTO);
}