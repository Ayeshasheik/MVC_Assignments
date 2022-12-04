using Microsoft.AspNetCore.Mvc;
using MVC_HOL_2.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace MVC_HOL_2.Controllers
{
    public class HomeController : Controller
    {
        /*
        // ----1-----
        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1>This is a demo of ContentResult</h1>");
            }
            else if (id.ToLower() == "plain")
            {
                return Content("<h1>This is a demo of ContentResult</h1>", "text/plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1>This is a demo of ContentResult</h1>", "text/html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1>This is a demo of ContentResult</h1>", "text/xml");
            }
            return Content("Invalid content type");
        }
        */
        // --------2-----
        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"C:\Lighthouse.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"C:\Lighthouse.jpg", "image/jpg",
           "default.jpg");
        }

        // ------3------
        /*
        public ActionResult Google()
        {
            return Redirect("http://www.google.com");
        }


        //------4-------
        public ActionResult StartPage()
        {
            return RedirectToAction("Index", new { id = "xml" });
        }

        // ----5-----

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        */
    }
}




