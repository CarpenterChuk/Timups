using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timups.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
        public int Description { get; set; }
        public List<WatchModel> Watches { get; set; }
    }
}
