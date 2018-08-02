using System.Collections.Generic;
using System.Threading.Tasks;
using VegaNew.Core.Models;
using VegaNew.Models;

namespace VegaNew.Core
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
        void Add(Vehicle vehicle);
        void Remove(Vehicle vehicle);
        Task<QueryResult<Vehicle>> GetVehicles(VehicleQuery filter);
    }
}