using Arbeidskrav_API.Features.Books.Classes;
using Microsoft.EntityFrameworkCore;

namespace Arbeidskrav_API.Data;

public class ArbeidskravAPIDbContext : DbContext
{
    public ArbeidskravAPIDbContext(DbContextOptions<ArbeidskravAPIDbContext> options) : base(options)
    {
    }
    
    public DbSet<Book> Books { get; set; }
    
}