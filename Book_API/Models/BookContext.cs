using Microsoft.EntityFrameworkCore;

namespace Book_API.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<DbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}