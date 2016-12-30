using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropStore.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Beskrivelse";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hvordan kontakte oss.";

            return View();
        }
    }
}