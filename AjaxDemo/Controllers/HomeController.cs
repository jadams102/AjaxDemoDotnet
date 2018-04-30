using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AjaxDemo.Models;


namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        private AjaxDemoDbContext db = new AjaxDemoDbContext();

        public IActionResult Index()
        {
            return View();
        }

        //Returns text
        public IActionResult HelloAjax()
        {
            return Content("Hello from the controller!", "text/plain");
        }

        //Returns the result of a method, taking parameters
        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            return Content((firstNumber + secondNumber).ToString(), "text/plain");
        }

        //Returns an object
        public IActionResult DisplayObject()
        {
            Destination destination = new Destination("Tokyo", "Japan", 1);
            return Json(destination);
        }

        //Returns a view
        public IActionResult DisplayViewWithAjax()
        {
            return View();
        }

        //Returns a random database object
        public IActionResult RandomDestinationList(int destinationCount)
        {
            var randomDestinationList = db.Destinations.OrderBy(r => Guid.NewGuid()).Take(destinationCount);
            return Json(randomDestinationList);
        }

        //Adds object to database
        [HttpPost]
        public IActionResult NewDestination(string newCity, string newCountry)
        {
            Destination newDestination = new Destination(newCity, newCountry);
            db.Destinations.Add(newDestination);
            db.SaveChanges();
            return Json(newDestination);
        }
    }
}
