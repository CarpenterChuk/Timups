using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Data.Interfaces;
using Timups.Models;
using Timups.ViewModels;

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
        public ActionResult List(string category)
        {
            string _category = category;
            IEnumerable<Watch> watches;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                watches = _watchRepository.Watches.OrderBy(p => p.WatchId);
                currentCategory = "All watches";
            }
            else
            {
                if (string.Equals("Smart", _category, StringComparison.OrdinalIgnoreCase))
                {
                    watches = _watchRepository.Watches.Where(p => p.Category.CategoryName.Equals("Smart")).OrderBy(p => p.Name);
                    currentCategory = "Smart watches";
                }
                else if (string.Equals("Quartz", _category, StringComparison.OrdinalIgnoreCase))
                {
                    watches = _watchRepository.Watches.Where(p => p.Category.CategoryName.Equals("Quartz")).OrderBy(p => p.Name);
                    currentCategory = "Quartz watches";
                }
                else if (string.Equals("Mechanical", _category, StringComparison.OrdinalIgnoreCase))
                {
                    watches = _watchRepository.Watches.Where(p => p.Category.CategoryName.Equals("Mechanical")).OrderBy(p => p.Name);
                    currentCategory = "Mechanical watches";
                }
                else
                {
                    watches = _watchRepository.Watches.OrderBy(p => p.WatchId);
                    currentCategory = "All watches";
                }
            }

            return View(new WatchListViewModel
            {
                Watches = watches,
                CurrentCategory = currentCategory
            });
        }
    }
}
