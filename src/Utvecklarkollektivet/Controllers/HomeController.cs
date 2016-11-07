using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Utvecklarkollektivet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult How()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Jobs()
        {
            return View();
        }
    }
}
