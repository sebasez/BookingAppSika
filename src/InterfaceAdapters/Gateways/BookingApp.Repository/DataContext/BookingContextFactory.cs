using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookingApp.Repository.DataContext
{
    public class BookingContextFactory : IDesignTimeDbContextFactory<BookingContext>
    {
        public BookingContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<BookingContext>();
            OptionsBuilder.UseSqlite("Data Source = database.db");
            return new BookingContext(OptionsBuilder.Options);
        }
    }
}
