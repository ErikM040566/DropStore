using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropStore.Controllers
{
    [Authorize]
    public class LoggController : BaseController
    {

        public ActionResult Index()
        {
            return View();
        }
    }
}