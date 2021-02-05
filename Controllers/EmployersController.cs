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
            //_context.Add(
            //    new ClientType
            //    {
            //     ClientTypeId =2,
            //     ClientTypeName ="B2C"
            //    });
            //_context.SaveChanges();
            return View("/Views/Employer/MyProfile.cshtml");
        }
       
       
        public IActionResult LogOut()
        {
            return View("/Views/Home/Index.cshtml");
        }
    }
}
