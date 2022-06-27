using NZWalks.api.Data;
using NZWalks.api.Models.Domain;

namespace NZWalks.api.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }

        public IEnumerable<Region> GetAll()
        {
          return  nZWalksDbContext.Regions.ToList();
        }
    }
}
