using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LiftIt.Controllers
{
    public class ObwodyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}