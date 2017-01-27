using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GridExample.Models;

namespace GridExample.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult IndexGrid(String search)
        {
            return PartialView("_IndexGrid", GetPeople(search));
        }

        private List<PersonModel> GetPeople(string search)
        {
            return new List<PersonModel>
            {
                new PersonModel
                {
                    Age = 31,
                    Birthday = new DateTime(1985,10,10),
                    IsWorking = true,
                    Name = "Simon",
                    Surname = "Scranton"
                },
                new PersonModel
                {
                    Age = 29,
                    Birthday = new DateTime(1988,5,1),
                    IsWorking = false,
                    Name = "Joe",
                    Surname = "Crosswave"
                },
                new PersonModel
                {
                    Age = 38,
                    Birthday = new DateTime(1978,6,5),
                    IsWorking = true,
                    Name = "Merry",
                    Surname = "Lisel"
                },
                new PersonModel
                {
                    Age = 26,
                    Birthday = new DateTime(1990,10,19),
                    Name = "Henry",
                    Surname = "Crux"
                }
            };
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
