using System.Collections.Generic;
using System.Threading.Tasks;
using VegaNew.Core.Models;


namespace VegaNew.Core
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<Photo>> GetPhotos(int vehicleId);
    }
}