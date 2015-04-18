using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            dynamic d = new System.Dynamic.ExpandoObject();
            d.Msg = "Hello World";
            return View("Index", d);
        }
    }
}