using MVC_TestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TestApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Car car = new Car(6);
            return View(car);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}