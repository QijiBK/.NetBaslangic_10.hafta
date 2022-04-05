using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_MVC_01.Controllers
{
    public class Hakkimda : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
