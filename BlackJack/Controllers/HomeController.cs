using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
namespace BlackJack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           // ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            Shoe testShoe = new Shoe(2);
            testShoe.FillShoe();
            testShoe.Shuffle();
            ViewBag.Message = testShoe.GetTopCard().ToString();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Debug.WriteLine("test");
            return View();
        }
        
    }
}
