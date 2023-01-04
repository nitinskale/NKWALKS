using NKWalks.API.Data;
using NKWalks.API.Models.Domain;

namespace NKWalks.API.Repository
{
    public class ResionRepository : IResionRepository
    {
        private readonly NKWalksDbContext nKWalksDbContext;

        public ResionRepository(NKWalksDbContext nKWalksDbContext)
        {
            this.nKWalksDbContext = nKWalksDbContext;
        }
        public IEnumerable<Region> GetAllRegions()
        {
           var regions = nKWalksDbContext.Regions.ToList();
            return regions;
        }
    }
}
