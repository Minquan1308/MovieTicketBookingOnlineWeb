using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MovieTicketBookingOnlineWebsite1.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }

            public DbSet<Movie> Movies { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<MovieImage> MovieImages { get; set; }
            //public DbSet<Screening> Screenings { get; set; }
            //public DbSet<User> Users { get; set; }
            //public DbSet<Ticket> Tickets { get; set; }
    }
}
