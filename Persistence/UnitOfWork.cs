using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegaNew.Core;

namespace VegaNew.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VegaNewDbContext context;

        public UnitOfWork(VegaNewDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
