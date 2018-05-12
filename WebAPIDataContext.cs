using Microsoft.EntityFrameworkCore;
using Models;

namespace lokvideoapi
{
    public class WebAPIDataContext : DbContext
    {
        public WebAPIDataContext(DbContextOptions<WebAPIDataContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}