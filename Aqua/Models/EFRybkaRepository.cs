using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aqua.Models
{
    public class EFRybkaRepository : IRybkaRepository
    {
        private ApplicationDBContext context;
        public EFRybkaRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Rybka> Rybki => context.Rybki;
    }
}
