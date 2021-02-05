using JobPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly jobportalContext _context;
        public CandidatesController(jobportalContext context)
        {
            _context = context;
        }
        //[Route("Candidate/MyProfile")]
        [HttpGet]
        public IActionResult MyProfile()
        {     
            return View("/Views/Candidate/MyProfile.cshtml"); 
        }

        [HttpGet]
        public IActionResult GetCandidats(int? employerId)
        {            
            return View("/Views/Employer/MyCandidates.cshtml");
        }
        public IActionResult LogOut()
        {       
            return View("/Views/Home/Index.cshtml");
        }
        
    }
}
