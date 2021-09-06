using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace firstproject.Controllers
{
    public class Logoutpg : Controller
    {
        [HttpPost]
        //[Authorize]
        public IActionResult logout()
        {
           // FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}
