using System.Data.Entity;
namespace Day_19
{
    class AppContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}
