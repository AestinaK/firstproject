using firstproject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstproject.Controllers
{
    public class Details : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult details()
        {
            selects();
            return View();
        }

        public IActionResult selects()
        {
            var data = dal.pgs.ToList();
            ViewBag.d = data[0];
            return RedirectToAction("details", "Detail");
        }
        [Route("Details/viewaccommodation/{id}")]
        public IActionResult viewaccommodation(int id)
        {
            var data = dal.pgs.Find(id);
            ViewBag.d = data;
            return View();
        }
        
    }
}
