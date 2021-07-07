using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Models;

namespace Timups.ViewModels
{
    public class WatchListViewModel
    {
        public IEnumerable<WatchModel> Watches { get; set; }
        public string CurrentCategory { get; set; }
    }
}
