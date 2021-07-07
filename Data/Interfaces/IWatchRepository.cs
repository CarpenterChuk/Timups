using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Models;

namespace Timups.Data.Interfaces
{
    public interface IWatchRepository
    {
        IEnumerable<Watch> Watches { get; }
        IEnumerable<Watch> PreferredWatches { get; }
        Watch GetWatchById(int watchId);
    }
}
