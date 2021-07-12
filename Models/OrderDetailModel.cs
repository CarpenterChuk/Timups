using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timups.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int WatchId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Watch Watch { get; set; }
        public virtual Order Order { get; set; }
    }
}
