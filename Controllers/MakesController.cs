using AutoMapper;
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
    public class MakesController : Controller
    {
        private readonly VegaNewDbContext context;
        private readonly IMapper mapper;

        public MakesController(VegaNewDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}
