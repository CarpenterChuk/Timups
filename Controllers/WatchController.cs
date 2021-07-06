using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Data.Interfaces;

namespace Timups.Controllers
{
    public class WatchController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IWatchRepository _watchRepository;
        public WatchController(ICategoryRepository categoryRepository, IWatchRepository watchRepository)
        {
            _categoryRepository = categoryRepository;
            _watchRepository = watchRepository;
        }
        public IActionResult Index()
        {
            return View();
        }        
        public IActionResult List()
        {
            var watches = _watchRepository.Watches;
            return View(watches);
        }
    }
}
