using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Data.Interfaces;
using Timups.Models;

namespace Timups.Data.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
