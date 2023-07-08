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

        public IActionResult Primary()
        {
            return View();
        }

        public IActionResult Ancillary()
        {
            return View();
        }
    }
}

class Doctor {
    public string name;
    public string place;
}
