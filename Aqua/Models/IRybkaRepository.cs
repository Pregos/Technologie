using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aqua.Models
{
    public interface IRybkaRepository
    {
        IQueryable<Rybka> Rybki { get; }
    }
}
