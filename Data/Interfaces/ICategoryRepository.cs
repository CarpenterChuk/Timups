using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Models;

namespace Timups.Data.Interfaces
{
    interface ICategoryRepository
    {
        IEnumerable<CategoryModel> Categories { get; }
    }
}
