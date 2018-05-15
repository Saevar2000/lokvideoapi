using Microsoft.EntityFrameworkCore;
using Models;

namespace lokvideoapi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}