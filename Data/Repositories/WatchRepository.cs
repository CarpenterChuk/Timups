using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Data.Interfaces;
using Timups.Models;

namespace Timups.Data.Repositories
{
    public class WatchRepository: IWatchRepository
    {
        private readonly AppDbContext _appDbContext;
        public WatchRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Watch> Watches => _appDbContext.Watches.Include(c => c.Category);

        public IEnumerable<Watch> PreferredWatches => _appDbContext.Watches.Where(p => p.IsPreferredWatch).Include(c => c.Category);

        public Watch GetWatchById(int watchId) => _appDbContext.Watches.FirstOrDefault(p => p.WatchId == watchId);
    }
}
