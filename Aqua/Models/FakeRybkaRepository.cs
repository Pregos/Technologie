using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aqua.Models
{
    public class FakeRybkaRepository : IRybkaRepository
    {
        public IQueryable<Rybka> Rybki => new List<Rybka>
        {
            new Rybka {Nazwa = "Akara"}
        }.AsQueryable<Rybka>();
    }
}
