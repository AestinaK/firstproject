using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstproject.Models;

namespace firstproject.Controllers
{
    public class DeletepgController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Delete(int id)
        {
            var data = dal.pgs.Find(id);
            dal.pgs.Remove(data);
            dal.SaveChanges();
            return RedirectToAction("Update","Updatepg");
        }
        public IActionResult Index(int id)
        {
            var data = dal.pgs.Find(id);
            ViewBag.d = data;
            return View();
        }
    }
}