using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Models;

namespace Timups.Data.Interfaces
{
    public interface IWatchRepository
    {
        IEnumerable<WatchModel> Watches { get; }
        IEnumerable<WatchModel> PreferredWatches { get; }
        WatchModel GetWatchById(int watchId);
    }
}
