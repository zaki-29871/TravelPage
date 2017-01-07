using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models;

namespace Travel.Controllers
{
    public class HomeController : Controller
    {
        private SelabTravelEntities db = new SelabTravelEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Member()
        {
            return View(from member in db.Member select member);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult PersonalInfo()
        {
            return View();
        }
    }
}