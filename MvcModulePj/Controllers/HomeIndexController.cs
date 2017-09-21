using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModulePj.Controllers
{
    public class HomeIndexController : Controller
    {
        // GET: HomeIndex
        public ActionResult Home()
        {
            return View();
        }
    }
}