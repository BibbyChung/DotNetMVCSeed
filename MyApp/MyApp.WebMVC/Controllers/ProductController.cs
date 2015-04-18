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
        private IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        // GET: Product
        public ActionResult Index()
        {
            var data = service.GetAllProductData();
            return View(data);
        }
    }

}