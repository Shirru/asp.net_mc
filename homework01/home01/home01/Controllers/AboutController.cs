using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using home01.Models;

namespace home01.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Pets()
        {
            var pets = ListOfPets.createPets();
            return View(pets);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}