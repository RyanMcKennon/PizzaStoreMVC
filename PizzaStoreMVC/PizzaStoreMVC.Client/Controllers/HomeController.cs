using PizzaStoreMVC.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.Client.Controllers
{
    public class HomeController : Controller
    { 
        [HttpGet]
        // GET: Home
        public ActionResult Index()
        {
            var orderModel = new PizzaOrder();

            return View(orderModel);
        }

        [HttpPost]
        public string Index(PizzaOrder order)
        {
            var sauce = order.options.Sauces.FirstOrDefault(s => s.Selected);
            return sauce.Text;
        }
    }
}