using System.Data.Entity;
using MemeHub.Data.Contracts;
using MemeHub.Models.Models;

namespace MemeHub.Data.Mocks
{
    public class FakeMemehubContext : IMemeHubContext
    {
        public FakeMemehubContext()
        {
            this.Memes = new FakeDbSet<Meme>();
            this.Comments = new FakeDbSet<Comment>();
            this.Posters = new FakeDbSet<Poster>();
        }
        public DbSet<Meme> Memes { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
