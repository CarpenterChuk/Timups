using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timups.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Watch> Watches { get; set; }
    }
}
