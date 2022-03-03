using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace floesm_pro.controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult contactUs()
        {
            return View();
        }
        public IActionResult shop()
        {
            return View();
        }
        public IActionResult shopDetail()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
    }
}
