using LibraryApp.Models;
namespace LibraryApp.Data;
using Microsoft.EntityFrameworkCore;

public class LibraryAppDbContext : DbContext
{
    
    public DbSet<User> User { get; set; }
    public DbSet<Book> Book { get; set; }
    public DbSet<LendBook> LendBook { get; set; }
    public LibraryAppDbContext(DbContextOptions<LibraryAppDbContext> options)
        : base(options)
    {
    }
    
  
}
