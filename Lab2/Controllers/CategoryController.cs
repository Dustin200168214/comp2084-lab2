using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(string name)
        {
            // Add product to our view bag container
            ViewBag.category = "You selected category: " + name;
            return View();
        }
    }
}