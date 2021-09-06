using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstproject.Models;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace firstproject.Controllers
{
    public class LoginController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult log()
         {
             //if (HttpContext.Session.GetString("id")!=null)
             //{
             //return View();
             //}
             // else
             //{
            //select all records
            List<Login> data = dal.login.ToList();
            ViewBag.data = data;
          return View();
         //}
         }

        [HttpPost]
        public IActionResult LoginCheck(Login logn)
        {
            //insert
            dal.login.Add(logn);
            dal.SaveChanges();
            ViewData["Message"] = "Login is succesfull";
            return RedirectToAction("astu","Astina");
        }
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Login(string email, string password)
        //    {
        //        if (ModelState.IsValid)
        //        {


        //            var f_password = GetMD5(password);
        //            var data = dal.Logins.Where(s => s.Email.Equals(email) && s.Password.Equals(f_password)).ToList();
        //            if (data.Count() > 0)
        //            {
        //                add session
        //                 Session["Password"] = data.FirstOrDefault().Password;
        //                 Session["Email"] = data.FirstOrDefault().Email;
        //                 Session["id"] = data.FirstOrDefault().id;
        //                return RedirectToAction("Index");
        //            }
        //            else
        //            {
        //                ViewBag.error = "Login failed";
        //                return RedirectToAction("Login");
        //            }
        //        }
        //        return View();
        //    }
        //    public static string GetMD5(string str)
        //    {
        //        MD5 md5 = new MD5CryptoServiceProvider();
        //        byte[] fromData = Encoding.UTF8.GetBytes(str);
        //        byte[] targetData = md5.ComputeHash(fromData);
        //        string byte2String = null;

        //        for (int i = 0; i < targetData.Length; i++)
        //        {
        //            byte2String += targetData[i].ToString("x2");

        //        }
        //        return byte2String;
        //    }
        //}
    }
}
