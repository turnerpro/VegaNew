using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VegaNew.Core;
using VegaNew.Core.Models;


namespace VegaNew.Persistence
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly VegaNewDbContext context;
        public PhotoRepository(VegaNewDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Photo>> GetPhotos(int vehicleId)
        {
            return await context.Photos
              .Where(p => p.VehicleId == vehicleId)
              .ToListAsync();
        }
    }
}