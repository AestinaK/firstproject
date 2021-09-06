using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstproject.Models;

namespace firstproject.Controllers
{
    public class UpdatepgController : Controller { 
        DataContext dal = new DataContext();

        public IActionResult Update()
            
        {
            select();
            return View();
        }
        
       public IActionResult select()
        {
            var data = dal.pgs.ToList();
            ViewBag.d = data;
            return RedirectToAction("Update", "Updatepg");
        }
        //delete 
        public IActionResult Delete(int id)
        {
            var data = dal.pgs.Find(id);
            dal.pgs.Remove(data);
            dal.SaveChanges();
            return RedirectToAction("Update", "Updatepg");
        }
        public IActionResult Updater(int id)
        {
            var data = dal.pgs.Find(id);
            ViewBag.d = data;
            return View();
        }
        public IActionResult Updat(Addpg pg)
        {
            dal.pgs.Update(pg);
            dal.SaveChanges();
            return RedirectToAction("Update", "Updatepg");
        }


    }
}