using FootBall_League_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace FootBall_League_Management.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext context = new MyDbContext();
        public ActionResult Index()
        {
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

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreateAccount(FootBallLeague a)
        {
            if (ModelState.IsValid)
            {
                context.FootBallLeague.Add(a);
                context.SaveChanges();
                return RedirectToAction("Create");
            }
            return View("Create");

        }


    }
}