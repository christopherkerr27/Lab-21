using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab21.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Registration registration)
        {
            // Save to a database??? 
            // Typically you would do something with this...
            // But for now we will just display the results

            return View(registration);
        }
    }
}
