using System.ComponentModel.DataAnnotations;

namespace Arbeidskrav_API.Features.Books.Classes;

public class Book
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Author { get; set; }
    
    [Required]
    [MaxLength(200)]
    public string Title { get; set; }
    
    [Required]
    public DateOnly Published { get; set; }
}