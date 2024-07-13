using INDWalks.API.Models.Domain;
using System.Runtime.InteropServices;

//definition of the all the methods which we will write inside this interface
namespace INDWalks.API.Repositories
{
    public interface IRegionRepository
    {
        //getting the list of all the regions back from the database
        Task<List<Region>> GetAllAsync();

        Task<Region?> GetByIdAsync(Guid id);

        Task<Region> CreateAsync(Region region);

        Task<Region?> UpdateAsync(Guid id, Region region);

        Task<Region?> DeleteAsync(Guid id);
    }
}


