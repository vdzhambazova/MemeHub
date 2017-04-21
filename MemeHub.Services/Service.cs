using MemeHub.Data;

namespace MemeHub.Services
{
    public abstract class Service
    {
        protected Service()
        {
            this.Context = new MemeHubContext();
        }
        public MemeHubContext Context { get; }
    }
}
