using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Theatre.Web.Models.Domain;
using Theatre.Web.Models.Identity;

namespace Theatre.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TheatreShow> TheatreShows { get; set; } = default!;
        public DbSet<Ticket> Tickets { get; set; } = default!;
    }
}
