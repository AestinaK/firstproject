using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstproject.Controllers
{
    public class OwnconController : Controller
    {
        public IActionResult dex()
        {
            return View();
        }
    }
}
