using NKWalks.API.Models.Domain;

namespace NKWalks.API.Repository
{
    public interface IResionRepository
    {
        IEnumerable<Region> GetAllRegions();
    }
}
