using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BadgerZoo.Controllers
{
    public class BadgerController : Controller
    {
        // GET: Badger
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Diet()
        {
            return View();
        }
    }
}