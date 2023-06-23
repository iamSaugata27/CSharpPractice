using DailySharePriceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DailySharePriceAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Stock> Stocks { get; set; }
    }
}
