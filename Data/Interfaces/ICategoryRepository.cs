using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Models;

namespace Timups.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
