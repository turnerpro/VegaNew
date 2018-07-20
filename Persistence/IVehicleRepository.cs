﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegaNew.Models;

namespace VegaNew.Persistence
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
        void Add(Vehicle vehicle);
        void Remove(Vehicle vehicle);
    }
}
