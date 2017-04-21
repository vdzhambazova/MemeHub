using System.Data.Entity;
using MemeHub.Models.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MemeHub.Data
{
    public class MemeHubContext : IdentityDbContext<ApplicationUser>
    {
        public MemeHubContext()
            : base("MemeHubContext", throwIfV1Schema: false)
        {
        }

        public DbSet<Meme> Memes { get; set; }

        public DbSet<Poster> Posters { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public static MemeHubContext Create()
        {
            return new MemeHubContext();
        }
    }
}