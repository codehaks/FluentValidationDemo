using Microsoft.EntityFrameworkCore;

namespace FluentValidationDemo.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext
            (DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }


    }
}
