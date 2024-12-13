using Class_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class_04.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            ViewBag.Message = "Message From View Bag";
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();
            string[] fruits = { "Apple", "Mango", "Banana", "Orange" };
            ViewBag.FruitsArray = fruits;
            ViewBag.SportsList = new List<string>()
            {
                "Cricket",
                "Football",
                "Hockey",
            };

            Employee employe = new Employee();

            employe.EmpId = 1;
            employe.EmpName = "Abdullah";
            employe.EmpDesignation = "Developer";
            ViewBag.employee = employe;

            return View();
        }
    }
}