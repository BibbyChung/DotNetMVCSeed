using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Common;
using MyApp.Services;
using MyApp.Interface.Services;

namespace MyApp.WebMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var service = AppHelper.CastleWindsorContainer.Resolve<IProductService>();

            var data = service.GetAllProductData();
            return View(data);
        }
    }

}