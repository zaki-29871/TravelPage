using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxTutorial.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string getName = Request.QueryString["name"];
            string postName = Request.Form["name"];

            if (getName != null)
                return View((object)(getName + " GET return"));

            else if (postName != null)
                return View((object)(postName + " POST return"));

            else return View((object)"error");
        }

        /*[HttpPost]
        public ActionResult Index(string name)
        {
            return View((object)(name + " POST return"));
        }*/

        [HttpPost]
        public string Ajax(string name)
        {
            return name + " Ajax return";
        }
    }
}