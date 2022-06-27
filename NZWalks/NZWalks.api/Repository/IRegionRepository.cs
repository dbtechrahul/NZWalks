using NZWalks.api.Models.Domain;

namespace NZWalks.api.Repository
{
    public interface IRegionRepository
    {
      IEnumerable<Region> GetAll();
    }
}
