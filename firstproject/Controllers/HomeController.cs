using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstproject.Models;

namespace firstproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        DataContext dal = new DataContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Display();
            return View();
        }

        public IActionResult Display()
        {
            var data = dal.pgs.ToList();
            ViewBag.d = data;
            return RedirectToAction("Index", "Home");
        }
        public IActionResult search()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Bankdetails(string search, Addpg bb)
        {
            if (search != null)
            {
                var dataselect = dal.pgs.ToList().Where((p => p.district.Contains(search)));
                ViewBag.data = dataselect;
                return View();
            }
            else
            {
                var dataselect = dal.pgs.ToList();
                ViewBag.data = dataselect;
                return View();
            }
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
