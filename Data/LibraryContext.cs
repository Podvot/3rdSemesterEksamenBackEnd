using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
        
    }

    public DbSet<Ingredient> Ingredients { get; set; } = null!;
    public DbSet<MenuItem> MenuItems { get; set; } = null!;
}