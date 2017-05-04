using System.Data.Entity;
using MemeHub.Data.Contracts;
using MemeHub.Data.Migrations;
using MemeHub.Models.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MemeHub.Data
{
    public class MemeHubContext : IdentityDbContext<ApplicationUser>, IMemeHubContext
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MemeHubContext, Configuration>());
            base.OnModelCreating(modelBuilder);

        }
    }
}