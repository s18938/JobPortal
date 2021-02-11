using JobPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Controllers
{
    public class JobOffersController : Controller
    {
        private readonly jobportalContext _context;
        public JobOffersController(jobportalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Map()
        {
            return View("/Views/Home/Map.cshtml");
        }
        [HttpGet]
        public IActionResult Index()
        {          
            return View("/Views/Home/Index.cshtml");
        }
        [HttpGet]
        public IActionResult GetJobOffers(int? employerId)
        {          
            return View("/Views/Employer/MyJobOffers.cshtml");
        }

        [HttpGet]
        public IActionResult MyJobOffers(int? candidateId)
        {
           
            return View("/Views/Candidate/MyAplications.cshtml");
        }

        
        public IActionResult Add()
        {
            return View("/Views/Employer/AddJobOffer.cshtml");
        }

       
        [Route("JobOffers/{Id?}/Edit")]
        public IActionResult Edit(int? Id)
        {
            return View("/Views/Employer/AddJobOffer.cshtml");
        }
    }
}
