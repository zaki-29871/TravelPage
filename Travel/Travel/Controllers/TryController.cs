using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Services;
using Travel.ViewModel;

namespace Travel.Controllers
{
    public class TryController : Controller
    {
        public TryServices tryService = new TryServices();

        // GET: Try
        public ActionResult Index()
        {
            TryViewModel viewModel = tryService.getName();
            

            return View(viewModel);
        }
    }
}