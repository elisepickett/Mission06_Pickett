using Microsoft.EntityFrameworkCore;

namespace Mission06_Pickett.Models
{
    public class AddMovieContext : DbContext
    {
        public AddMovieContext(DbContextOptions<AddMovieContext> options) : base(options) { }

        public DbSet<Application> Movies { get; set; }
    }
}
