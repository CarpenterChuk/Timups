using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Data.Interfaces;
using Timups.Models;

namespace Timups.Data.Mocks
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Smart", Description = "All smart watches" },
                         new Category { CategoryName = "Quartz", Description = "All quartz watches" },
                         new Category { CategoryName = "Mechanical", Description = "All mechanical watches" }
                     };
            }
        }
    }
}
