using System.Data.Entity;
using MemeHub.Models.Models;

namespace MemeHub.Data.Contracts
{
    public interface IMemeHubContext
    {
        DbSet<Meme> Memes { get; set; }

        DbSet<Poster> Posters { get; set; }

        DbSet<Comment> Comments { get; set; }
    }
}
