using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Models;

namespace Timups.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Watch> PreferredWathes{ get; set; }
    }
}
