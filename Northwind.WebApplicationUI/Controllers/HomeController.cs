using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Northwind.Business.Concrete;
using Northwind.WebApplicationUI.Models;

namespace Northwind.WebApplicationUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ProductManager productManager = new ProductManager();
            //ProductViewModel productViewModel = new ProductViewModel();
            //var list = productManager.GetAll();
            //productViewModel.ProductList = list;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}