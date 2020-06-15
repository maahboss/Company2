using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Company.Controllers;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [AllowAnonymous]
        public ActionResult Index()
        {
            var list = db.Orders.ToList();
            return View(list);
        }


        public ActionResult ListFiles()
        {
            var list = db.Orders.ToList();
            return View(list);
        }

        public ActionResult ListComFiles()
        {
            var list1 = db.Exporters.ToList();
            return View(list1);
        }

        public ActionResult OrdersSearch()
        {
            var list = db.Orders.ToList();
            return View(list);
        }
        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AllowAnonymous]

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        

        public ActionResult Search(string searching)
        {

            var result = db.Orders.Where(a => a.OrderNo.Contains(searching) || searching == null || a.Note.Contains(searching)).ToList();
            return View(result);



        }

        

        [Authorize]
        public ActionResult MainMenu()
        {
            return View();
        }
        


    }
}