using System.Linq;
using Microsoft.AspNetCore.Mvc;
using firstproject.Models;
namespace firstproject.Controllers
{

    public class SigninController : Controller
    {
        DataContext dal = new DataContext();

        public ActionResult Sign()
        {
            return View("sign");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Sign(Signin register)
        {

            if (ModelState.IsValid)
            {
                using (var dal = new DataContext())
                {

                    Signin ss = new Signin();
                    ss.Email = register.Email;
                    ss.Name = register.Name;
                    ss.Password = register.Password;
                    dal.Signins.Add(ss);
                    dal.SaveChanges();
                }

                ViewData["Message"] = "User Details Saved";
                return View("sign");
            }
            else
            {

                return View("sign", register);
            }
        }
    }
            }
 

