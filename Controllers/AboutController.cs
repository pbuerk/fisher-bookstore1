using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("About the Index!");
        }
        public IActionResult History()
        {
            return Content("About the History!");
        }
        public IActionResult Location ()
        {
            return Content("About the Location!");
        }
    }
}