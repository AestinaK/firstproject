using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstproject.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult message()
        {
            return View();
        }
    }
}
