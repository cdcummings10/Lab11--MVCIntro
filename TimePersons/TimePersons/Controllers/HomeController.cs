using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimePersons.Models;

namespace TimePersons.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            ChosenYears chosenYears = new ChosenYears(startYear, endYear);
            return RedirectToAction("Results", chosenYears);
        }

        public ViewResult Results(ChosenYears years)
        {
            TimePerson timePerson = new TimePerson();
            timePerson.GetPersons(years);
            return View(timePerson.GetPersons(years));
        }
    }
}
