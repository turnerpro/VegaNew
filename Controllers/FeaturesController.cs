using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegaNew.Controllers.Resources;
using VegaNew.Models;
using VegaNew.Persistence;

namespace VegaNew.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly VegaNewDbContext context;
        private readonly IMapper mapper;
        public FeaturesController(VegaNewDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
        }
    }
}
