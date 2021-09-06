using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace firstproject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult contactus()
        {
            return View();
        }
    }
}