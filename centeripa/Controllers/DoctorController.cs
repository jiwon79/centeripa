using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using centeripa.Models;

namespace centeripa.Controllers
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
            DoctorRepository repository = new DoctorRepository();

            List<DoctorModel> list = repository.GetList();

            return View(list);
        }

        public IActionResult Ancillary()
        {
            return View();
        }
    }
}
