using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekat.Models;

namespace projekat.Controllers
{
    public class MainSiteController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ModelKoren mejl)
        {
            return View("unetaAdresa", mejl);
        }

        public ActionResult About() 
        {
            return View();
        }
        public ActionResult Services() 
        {
            return View();
        }
        public ActionResult Portfolio() 
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Kontakt() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kontakt(ModelKoren kandidat)
        {
            return View("kandidat",kandidat);
        }
    }
}