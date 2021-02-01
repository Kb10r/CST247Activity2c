using Activity2c.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2c.Controllers
{
    public class AppointmentController : Controller
    {
        static List<AppointmentModel> appointments = new List<AppointmentModel>();
        public IActionResult Index()
        {
            return View(appointments);
        }

        public IActionResult Create() 
        {
            return View();
        }

        public IActionResult Details(AppointmentModel am) 
        {
            appointments.Add(am);
            return View("Details", am);
        }
    }
}
