using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace centeripa
{
    public class DoctorController : Controller
    {
        // GET: /Doctor/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Doctor/Specialist
        public IActionResult Specialist()
        {
            return View();
        }
    }
}

