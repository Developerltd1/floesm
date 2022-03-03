using floesm_pro.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace floesm_pro.Controllers
{
    //[Authorize]
    public class MainController : Controller
    {
        private readonly floesm_proContext _floesm_ProContext;
        private readonly  IWebHostEnvironment _hostingEnvironment;

        public MainController(floesm_proContext floesm_ProContext, IWebHostEnvironment hostingEnvironment)
        {
            _floesm_ProContext = floesm_ProContext;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ArtGallery()
        {
            return View();
        }
        public IActionResult ArtGalleryFeatured()
        {
            var model = _floesm_ProContext.UploadedImages.Select(x => new UploadedImages
            {
                Id = x.Id,
                ImageUrl = x.ImageUrl
            });
            return View(model);
        }
        public IActionResult TestArtGalleryFeatured()
        {
            return View();
        }
        public IActionResult UploadImages()
        {
            var model = _floesm_ProContext.UploadedImages.Select(x => new UploadedImages
            {
                Id = x.Id,
                ImageUrl = x.ImageUrl
            });
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile formFile)
        {
            if (formFile != null)
            {
                string fileName = System.IO.Path.GetFileName(formFile.FileName);
                string TempPath = $"~/img/{fileName}";
                string BasePath = Path.Combine(_hostingEnvironment.WebRootPath, "img");
                //Set the Image File Path.
                string filePath = $"{BasePath}\\{fileName}";
                //Save the Image File in Folder.
                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(fileStream);
                }
                //Insert the Image File details in Table.
                _floesm_ProContext.UploadedImages.Add(new UploadedImages
                {
                    ImageUrl = TempPath,
                });
                _floesm_ProContext.SaveChanges();
            }
            return RedirectToAction("UploadImages");
        }
        public IActionResult GetUploadImagePopup()
        {
            return PartialView("_uploadImagePartialview");
        }
        
        public IActionResult VerifyKey(string Key)
        {
            if(!string.IsNullOrEmpty(Key))
            {
                if (Key.ToLower() == "!@#$%floesm")
                {
                    return Json(new { msg = "MATCHED", status = true});
                }
                return Json(new { msg = "You entered in-valid key", status = false });
            }
            return Json(new {msg = "Key can't be null",status= false });
        }
    }
}
