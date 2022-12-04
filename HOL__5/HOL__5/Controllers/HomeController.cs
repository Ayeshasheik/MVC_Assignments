using HOL__5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HOL__5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        static List<User> users = new List<User>();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetServerTime()
        {
            System.Threading.Thread.Sleep(5000);
            return PartialView();
        }
        public ActionResult GetAllUsers()
        {
            return PartialView(users);
        }

        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(User u)
        {
            users.Add(u);
            return RedirectToAction("GetAllUsers");
        }

    }
}