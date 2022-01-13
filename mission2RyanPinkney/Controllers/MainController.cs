// Author: Ryan Pinkney
// Main Controller


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mission2RyanPinkney.Models; // Import the models

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mission2RyanPinkney.Controllers
{
    public class MainController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/ for the grade calculator html page
        [HttpGet]
        public IActionResult GradeCal()
        {
            return View();
        }

        // Grade Calculator post method for the form
        [HttpPost]
        public IActionResult GradeCal(GradeCal model)
        {
            return View();
        }
    }
}
