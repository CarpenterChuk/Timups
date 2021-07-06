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
        public IEnumerable<CategoryModel> Categories
        {
            get
            {
                return new List<CategoryModel>
                     {
                         new CategoryModel { CategoryName = "Smart", Description = "All smart watches" },
                         new CategoryModel { CategoryName = "Quartz", Description = "All quartz watches" },
                         new CategoryModel { CategoryName = "Mechanical", Description = "All mechanical watches" }
                     };
            }
        }
    }
}
