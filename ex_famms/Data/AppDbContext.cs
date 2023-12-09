using ex_famms.Models;
using Microsoft.EntityFrameworkCore;

namespace ex_famms.Data
{
    public class AppDbContext : DbContext
    {
        internal object Testimonials;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Query> Query { get; set; }


    }
}
