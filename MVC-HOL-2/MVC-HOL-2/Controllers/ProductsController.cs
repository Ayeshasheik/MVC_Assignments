using Microsoft.AspNetCore.Mvc;

namespace MVC_HOL_2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            Models.Product p = new Models.Product();

            //pass a list of products to the view
            return View(p.GetProducts());
        }
    }
}
