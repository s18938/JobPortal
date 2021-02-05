using JobPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Controllers
{
    public class EmployersController : Controller
    {
        private readonly jobportalContext _context;
        public EmployersController(jobportalContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult MyProfile()
        {           
            return View("/Views/Employer/MyProfile.cshtml");
        }
       
       
        public IActionResult LogOut()
        {
            return View("/Views/Home/Index.cshtml");
        }
    }
}
