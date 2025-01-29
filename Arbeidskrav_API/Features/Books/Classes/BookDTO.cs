namespace Arbeidskrav_API.Features.Books.Classes;

public class BookDTO
{
    public Guid Id { get; set; }
    
    public string Author { get; set; }
    
    public string Title { get; set; }
    
    public DateOnly Published { get; set; }
}