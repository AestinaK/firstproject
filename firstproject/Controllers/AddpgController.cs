using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstproject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace firstproject.Controllers
{
    public class AddpgController : Controller
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        public AddpgController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        public async Task<string> UploadImage(string folderpath, IFormFile file)
        {
            folderpath += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderpath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderpath;
        }


        DataContext dal = new DataContext();
        public IActionResult Add()
        {

            //selec all record
            var dataselect = dal.pgs.ToList();
            ViewBag.data = dataselect;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Addpg pg, IFormFile file)
        {
            string folder = "image/pgimage/";

            Addpg obj = new Addpg()
            {
                id = pg.id,
                title=pg.title,
                type=pg.type,
                district=pg.district,
                city=pg.city,
                rent=pg.rent,
                rooms=pg.rooms,
                email=pg.email,
                address=pg.address,
                picture= await UploadImage(folder,file),
                electricity =pg.electricity,
                ac=pg.ac,
                fan=pg.fan,
                parking=pg.parking,
                furnished=pg.furnished,
                internet=pg.internet,
                security=pg.security,
                types=pg.types
            };

            dal.pgs.Add(obj);
            dal.SaveChanges();
            return RedirectToAction("Add");

        }

        public string OpenPopup()
        {
            return " Data added successfully!";
        }

    }
}

