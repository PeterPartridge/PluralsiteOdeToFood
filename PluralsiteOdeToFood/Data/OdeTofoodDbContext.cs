using Microsoft.EntityFrameworkCore;
using PluralsiteOdeToFood.Models;

namespace PluralsiteOdeToFood.Data
{
    public class OdeTofoodDbContext : DbContext
    {
        public OdeTofoodDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public object Restaurant { get; internal set; }
    }
}
